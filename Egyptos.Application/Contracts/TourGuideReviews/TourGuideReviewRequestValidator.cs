namespace Egyptos.Application.Contracts.TourGuideReviews;

public class TourGuideReviewRequestValidator : AbstractValidator<TourGuideReviewRequest>
{
    public TourGuideReviewRequestValidator()
    {
        RuleFor(x => x.Comment).NotEmpty().WithMessage("Comment cannot be empty");
        RuleFor(x => x.Rate).NotEmpty().WithMessage("Rate cannot be empty");

    }
}
