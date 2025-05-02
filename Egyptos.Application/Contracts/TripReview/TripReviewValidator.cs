namespace Egyptos.Application.Contracts.TripReview;
public class TripReviewValidator:AbstractValidator<TripReviewRequest>
{
    public TripReviewValidator()
    {
        RuleFor(x => x.Comment).NotEmpty().WithMessage("Comment cannot be empty");
        RuleFor(x => x.Rate).NotEmpty().WithMessage("Rate cannot be empty");

        RuleFor(s => s.ImageUrl)
            .NotNull()
            .Must(ValidateFile)
            .WithMessage("Invalid file. Allowed file types are .jpg, .jpeg, .png, and max size is 5MB.")
            .When(x => x.ImageUrl != null);
    }
    private static bool ValidateFile(IFormFile file)
    {
        if (file == null || file.Length == 0)
            return false;

        var allowedExtensions = new[] { ".jpg", ".jpeg", ".png" };
        var extension = Path.GetExtension(file.FileName).ToLower();

        if (!allowedExtensions.Contains(extension))
            return false;


        const long maxFileSize = 5 * 1024 * 1024; // 5MB
        return file.Length <= maxFileSize;
    }
}
