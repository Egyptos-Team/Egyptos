using Egyptos.Application.Contracts.Users;
using Egyptos.Domain.Entities;

namespace Egyptos.Application.Contracts.TourGuide;
public record TourGuideResponse
(
    int Id,
    string UserId,
    double SalaryPerHour,
    string Description,
    int YearsOfExperience,
    double Rate,
    bool IsAvailable,
    bool IsActive,
    TouGuideUserResponse User
);
