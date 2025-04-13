namespace Egyptos.Application.Contracts.Items;
internal class ItemsRequestValidator : AbstractValidator<ItemsRequest>
{
    public ItemsRequestValidator()
    {
        RuleFor(x => x.Title)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.Description)
            .NotNull();

        RuleFor(x => x.Date)
            .NotNull();

        RuleFor(s => s.Image)
            .NotNull()
            .Must(ValidateFile)
            .WithMessage("Invalid file. Allowed file types are .jpg, .jpeg, .png, and max size is 5MB.");
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
