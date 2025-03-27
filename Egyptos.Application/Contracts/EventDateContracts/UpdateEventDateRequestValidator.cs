namespace Egyptos.Application.Contracts.EventDateContracts;

public class UpdateEventDateRequestValidator : AbstractValidator<UpdateEventDateRequest>
{
    public UpdateEventDateRequestValidator()
    {
        RuleFor(x => x.StartDate)
           .NotEmpty();

        RuleFor(x => x.EndDate)
           .NotEmpty();

        RuleFor(x => x.StartSubscription)
           .NotEmpty();

        RuleFor(x => x.EndSubscription)
            .NotEmpty();

        RuleFor(x => x.Description)
            .NotEmpty();

        RuleFor(x => x.Location)
            .NotEmpty();

        RuleFor(x => x.Price)
            .NotEmpty();

        RuleFor(s => s.Images)
            .NotNull()
            .Must(ValidateFile)
            .WithMessage("Invalid file. Allowed file types are .jpg, .jpeg, .png, and max size is 5MB.");

        RuleFor(x => x)
               .Must(HasValidDates)
               .WithName(nameof(CreateEventDateRequest.EndDate))
               .WithMessage("{PropertyName} must be grater than or equal start date");

        RuleFor(x => x)
               .Must(HasValidSubscription)
               .WithName(nameof(CreateEventDateRequest.EndSubscription))
               .WithMessage("{PropertyName} must be grater than or equal start subscription");
    }
    private static bool ValidateFile(List<IFormFile> files)
    {
        foreach (var file in files)
        {
            if (file == null || file.Length == 0)
                return false;

            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png" };
            var extension = Path.GetExtension(file.FileName).ToLower();

            if (!allowedExtensions.Contains(extension))
                return false;


            const long maxFileSize = 5 * 1024 * 1024; // 5MB
            if (file.Length > maxFileSize)
                return false;
        }
        return true;
    }

    private bool HasValidDates(UpdateEventDateRequest request) =>
        request.StartDate <= request.EndDate;

    private bool HasValidSubscription(UpdateEventDateRequest request) =>
        request.StartSubscription <= request.EndSubscription;

}