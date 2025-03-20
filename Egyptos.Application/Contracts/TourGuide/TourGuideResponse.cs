using Egyptos.Application.Contracts.TourGuideReviews;
using Egyptos.Application.Contracts.Users;

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
    TouGuideUserResponse User,
    List<TourGuideReviewResponse> Reviews
);


public record CustomTourGuideResponse
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
