namespace Egyptos.Domain.Entities;

public class ChatMessage
{
    public int Id { get; set; }
    public string UserMessage { get; set; } = string.Empty;
    public string BotResponse { get; set; } = string.Empty;
  
}
