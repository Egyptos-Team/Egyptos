namespace Egyptos.Application.Contracts.Working;
public record WorkingRequest
(
    string Day,
    TimeOnly StartTime,
    TimeOnly EndTime
);
