using Egyptos.Application.Contracts.ChatMessage;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Text.Json;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Egyptos.Application.Services.Implementations;
public class ChatMessageService : IChatMessageService
{
    private readonly ApplicationDbContext _context;
    private readonly IWebHostEnvironment _webHostEnvironment;

    private static readonly string ApiKey = "AIzaSyCZ-1D3PVny0WD2Qzz_2rYi-C2a7VWv24Q";
    private static readonly string ApiEndpoint = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash-lite:generateContent";
    private readonly string _jsonFilePath;

    class QAPair
    {
        public string question { get; set; }
        public string answer { get; set; }
    }

    // Inject IWebHostEnvironment to access wwwroot
    public ChatMessageService(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
    {
        _context = context;
        _webHostEnvironment = webHostEnvironment;

        // Set the path to the JSON file in wwwroot
        _jsonFilePath = Path.Combine(_webHostEnvironment.WebRootPath, "data", "q.json");
    }

    string Main(string request)
    {
        List<QAPair> qaContext;
        try
        {
            // Read the JSON file from wwwroot
            string jsonContent = File.ReadAllText(_jsonFilePath);
            qaContext = JsonSerializer.Deserialize<List<QAPair>>(jsonContent);
        }
        catch (Exception ex)
        {
            return $"Error loading context from {_jsonFilePath}: {ex.Message} - Make sure the q.json file exists in the wwwroot/data directory.";
        }

        using var httpClient = new HttpClient();

        string question = request;

        if (string.IsNullOrEmpty(question) || question.ToLower() == "exit")
            return "No question provided.";

        try
        {
            // First check for direct Q&A matches
            var (qaResponse, qaScore) = FindQAMatch(qaContext, question);

            if (qaResponse != null && qaScore > 0.7) // Higher threshold for direct matches
            {
                return qaResponse;
            }

            // Otherwise use Gemini API with context
            string context = PrepareContext(qaContext);
            string answer = AskGeminiWithContext(httpClient, question, context);
            return answer;
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    static string PrepareContext(List<QAPair> qaContext)
    {
        // Format context similar to Python version
        StringBuilder contextBuilder = new StringBuilder();
        contextBuilder.AppendLine("Here are some common questions and answers about Egypt tourism:");
        contextBuilder.AppendLine();

        // Limit to 15 items to avoid token limits
        foreach (var pair in qaContext.Take(15))
        {
            contextBuilder.AppendLine($"Q: {pair.question}");
            contextBuilder.AppendLine($"A: {pair.answer}");
            contextBuilder.AppendLine();
        }

        return contextBuilder.ToString();
    }

    static (string, double) FindQAMatch(List<QAPair> qaContext, string query, double threshold = 0.6)
    {
        if (string.IsNullOrEmpty(query) || !qaContext.Any())
            return (null, 0);

        query = query.ToLower().Trim();
        string bestMatch = null;
        double bestScore = 0;

        foreach (var pair in qaContext)
        {
            string question = pair.question.ToLower();

            // Simple word match scoring
            var queryWords = new HashSet<string>(query.Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries));
            var questionWords = new HashSet<string>(question.Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries));
            var commonWords = queryWords.Intersect(questionWords).ToList();

            if (commonWords.Any())
            {
                // Calculate Jaccard similarity: intersection over union
                double score = (double)commonWords.Count / queryWords.Union(questionWords).Count();

                if (score > bestScore && score >= threshold)
                {
                    bestScore = score;
                    bestMatch = pair.answer;
                }
            }
        }

        return (bestMatch, bestScore);
    }

    static int CountMatchingWords(string text1, string text2)
    {
        var words1 = text1.Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
        var words2 = text2.Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
        return words1.Count(w => words2.Contains(w));
    }

    static string AskGeminiWithContext(HttpClient client, string question, string context)
    {
        string prompt = $"""
            You are a tourism assistant specializing in Egypt travel.

            {context}

            Question: {question}

            Answer the question about Egypt tourism. Consider:
            - Historical sites and attractions
            - Cultural information
            - Practical travel advice
            - Safety information
            - Local customs

            Answer concisely but informatively, referencing the provided Q&A context above when applicable.
            """;

        var requestData = new
        {
            contents = new[]
            {
                new
                {
                    parts = new[]
                    {
                        new { text = prompt }
                    }
                }
            },
            generationConfig = new
            {
                maxOutputTokens = 200,
                temperature = 0.7
            }
        };

        string jsonRequest = JsonSerializer.Serialize(requestData);
        var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
        string url = $"{ApiEndpoint}?key={ApiKey}";

        var response = client.PostAsync(url, content).GetAwaiter().GetResult();

        if (!response.IsSuccessStatusCode)
        {
            string errorContent = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            throw new Exception($"API request failed with status code {response.StatusCode}: {errorContent}");
        }

        string jsonResponse = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
        using JsonDocument doc = JsonDocument.Parse(jsonResponse);
        JsonElement root = doc.RootElement;

        if (root.TryGetProperty("candidates", out JsonElement candidates) &&
            candidates.GetArrayLength() > 0 &&
            candidates[0].TryGetProperty("content", out JsonElement contentElement) &&
            contentElement.TryGetProperty("parts", out JsonElement parts) &&
            parts.GetArrayLength() > 0 &&
            parts[0].TryGetProperty("text", out JsonElement textElement))
        {
            return textElement.GetString() ?? "No text found in response";
        }

        return ("Unexpected response format");
    }

    public async Task<Result<List<ChatMessageResponse>>> GetAllAsync()
    {
        var chats = await _context.ChatMessages.AsNoTracking()
            .ProjectToType<ChatMessageResponse>()
            .ToListAsync();
        return Result.Success(chats);
    }

    public async Task<Result<ChatMessageResponse>> GetAsync(int id)
    {
        if (await _context.ChatMessages.FindAsync(id) is not { } chat)
            return Result.Failure<ChatMessageResponse>(ChatMessageError.NotFound);

        return Result.Success(chat.Adapt<ChatMessageResponse>());
    }

    public async Task<Result<ChatMessageResponse>> AskAsync(ChatMessageRequest request)
    {
        var result = Main(request.Question);

        if (result is null)
            return Result.Failure<ChatMessageResponse>(ChatMessageError.NotFound);

        var row = new ChatMessage
        {
            UserMessage = request.Question,
            BotResponse = result.ToString()
        };

        await _context.ChatMessages.AddAsync(row);
        await _context.SaveChangesAsync();

        return Result.Success(row.Adapt<ChatMessageResponse>());
    }

    public async Task<Result> DeleteAsync(int id)
    {
        if (await _context.ChatMessages.FindAsync(id) is not { } chat)
            return Result.Failure<ChatMessageResponse>(ChatMessageError.NotFound);

        _context.ChatMessages.Remove(chat);

        await _context.SaveChangesAsync();

        return Result.Success();
    }
}