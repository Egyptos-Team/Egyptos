using Egyptos.Application.Contracts.Users;

namespace Egyptos.Application.Contracts.TourGuide;

public record CreateTourGuideResponse
(
    int Id,
    string UserId,
    double SalaryPerHour,
    string Description,
    int YearsOfExperience
);

public record UpdateTourGuideResponse
(
    int Id,
    string UserId,
    double SalaryPerHour,
    string Description,
    int YearsOfExperience,
    double Rate,
    bool IsAvailable,
    bool IsActive
);
