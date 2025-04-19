
using Egyptos.Application.Contracts.ChatMessage;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Text.Json;

namespace Egyptos.Application.Services.Implementations;
public class ChatMessageService(ApplicationDbContext context) : IChatMessageService
{
    private readonly ApplicationDbContext _context = context;

    private static readonly string ApiKey = "AIzaSyCZ-1D3PVny0WD2Qzz_2rYi-C2a7VWv24Q";
    private static readonly string ApiEndpoint = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash-lite:generateContent";
    private static readonly string JsonFilePath = "E:/projects/graduate/Egyptos-Team/Egyptos/Egyptos.Api/bin/Debug/net9.0/q.json";

    class QAPair
    {
        public string question { get; set; }
        public string answer { get; set; }
    }


    static string Main(string request)
    {
        List<QAPair> qaContext;
        try
        {
            string jsonContent = File.ReadAllText(JsonFilePath);
            qaContext = JsonSerializer.Deserialize<List<QAPair>>(jsonContent);
        }
        catch (Exception ex)
        {
            return $"Error loading context from {JsonFilePath}: {ex.Message} - Make sure the q.json file is in the same directory as the executable.";
        }

        using var httpClient = new HttpClient();

        string question = request;

        if (string.IsNullOrEmpty(question) || question.ToLower() == "exit")
            return "No question provided.";

        try
        {
            string context = PrepareContext(qaContext, question);
            string answer = AskGeminiWithContext(httpClient, question, context);
            return answer;
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    static string PrepareContext(List<QAPair> qaContext, string userQuestion)
    {
        var relevantPairs = qaContext
            .OrderByDescending(pair =>
                CountMatchingWords(pair.question.ToLower(), userQuestion.ToLower()))
            .Take(5)
            .ToList();

        StringBuilder contextBuilder = new StringBuilder();
        contextBuilder.AppendLine("Here's some relevant information about Egypt:");

        foreach (var pair in relevantPairs)
        {
            contextBuilder.AppendLine($"Q: {pair.question}");
            contextBuilder.AppendLine($"A: {pair.answer}");
            contextBuilder.AppendLine();
        }

        return contextBuilder.ToString();
    }

    static int CountMatchingWords(string text1, string text2)
    {
        var words1 = text1.Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
        var words2 = text2.Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
        return words1.Count(w => words2.Contains(w));
    }

    static string AskGeminiWithContext(HttpClient client, string question, string context)
    {
        string prompt = $"{context}\n\nBased on the information above, please answer this question in 100 words or less: {question}";

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

        throw new Exception("Unexpected response format");
    }



    public async Task<Result<List<ChatMessageResponse>>> GetAllAsync()
    {

        var chats= await _context.ChatMessages.AsNoTracking()
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
    public async  Task<Result<ChatMessageResponse>> CreateAsync(ChatMessageRequest request)
    {
        var result = Main(request.Question);

        if (result is null )
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
