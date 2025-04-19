using Egyptos.Application.Contracts.ChatMessage;

namespace Egyptos.Application.Services.Interfaces;

public interface IChatMessageService
{
    Task<Result<List<ChatMessageResponse>>> GetAllAsync();
    Task<Result<ChatMessageResponse>> GetAsync(int id);
    Task<Result<ChatMessageResponse>> CreateAsync(ChatMessageRequest request);
    Task<Result> DeleteAsync(int id);
}
