namespace Egyptos.Application.Contracts.TourGuide;

public record CreateTourGuideRequest
(
    double SalaryPerHour,
    string Description,
    int YearsOfExperience,
    bool IsAvailable,
    bool IsActive,
    string UserId
);

public record UpdateTourGuideRequest
(
    double SalaryPerHour,
    string Description,
    int YearsOfExperience,
    double Rate,
    bool IsAvailable,
    bool IsActive
);
