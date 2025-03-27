namespace Egyptos.Application.Contracts.PrivateTransportReview;
internal class PrivateTransportReviewRequestValidator : AbstractValidator<PrivateTransportReviewRequest>
{
    public PrivateTransportReviewRequestValidator()
    {
        RuleFor(x => x.Comment).NotEmpty().WithMessage("Comment cannot be empty");
        RuleFor(x => x.Rate).NotEmpty().WithMessage("Rate cannot be empty");
    }
}

