using Microsoft.AspNetCore.Http;

namespace Egyptos.Domain.Errors;

public class ChatMessageError
{

    public static readonly Error NotFound
        = new("Chat.NotFound", "Chat is not exists", StatusCodes.Status404NotFound);
}
