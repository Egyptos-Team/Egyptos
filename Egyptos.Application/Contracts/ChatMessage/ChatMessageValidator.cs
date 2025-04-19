using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egyptos.Application.Contracts.ChatMessage;

public class ChatMessageValidator : AbstractValidator<ChatMessageRequest>
{
    public ChatMessageValidator()
    {
        RuleFor(x => x.Question)
            .NotEmpty();


    }
}
