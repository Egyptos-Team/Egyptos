namespace Egyptos.Application.Contracts.ChatMessage;

public  class ChatMessageResponse
{
    public int Id { get; set; }
    public string UserMessage { get; set; } = string.Empty;
    public string BotResponse { get; set; } = string.Empty;
}
