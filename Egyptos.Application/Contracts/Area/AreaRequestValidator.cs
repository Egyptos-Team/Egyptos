using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace Egyptos.Application.Contracts.Area;

public class AreaRequestValidator : AbstractValidator<AreaRequest>
{
    public AreaRequestValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .Length(3, 20);

        RuleFor(x => x.Address)
            .NotEmpty()
            .Length(3, 50);

        RuleFor(x => x.Description)
            .NotEmpty();

        RuleFor(x => x.Location)
            .NotEmpty();

        RuleFor(x => x.ImageUrl)
            .NotEmpty();

        RuleFor(x => x.AreaTypeId)
            .NotEmpty()
            .GreaterThan(0);

        RuleFor(s => s.AreaImages)
           .NotNull()
           .Must(ValidateFile)
           .WithMessage("Invalid file. Allowed file types are .jpg, .jpeg, .png, and max size is 5MB.")
           .When(x=>x.AreaImages!=null);

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

}
