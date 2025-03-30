namespace Egyptos.Application.Contracts.Working;
public record WorkingResponse
(
    int Id,
    string Day,
    TimeOnly StartTime,
    TimeOnly EndTime
);