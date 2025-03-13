using Egyptos.Application.Contracts.EventDateContracts;
using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace Egyptos.Application.Contracts.EventImages;

public class CreateEventImageRequestValidator : AbstractValidator<CreateEventImageRequest>
{
    public CreateEventImageRequestValidator()
    {
        RuleFor(s => s.EventId)
            .NotNull();

        //RuleFor(s => s.ImageUrl)
        //    .NotNull()
        //    .Must(ValidateFile)
        //    .WithMessage("Invalid file. Allowed file types are .jpg, .jpeg, .png, and max size is 5MB.");
    }

    //private static bool ValidateFile(IFormFile file)
    //{
    //    if (file == null || file.Length == 0)
    //        return false;

    //    var allowedExtensions = new[] { ".jpg", ".jpeg", ".png" };
    //    var extension = Path.GetExtension(file.FileName).ToLower();

    //    if (!allowedExtensions.Contains(extension))
    //        return false;


    //    const long maxFileSize = 5 * 1024 * 1024; // 5MB
    //    return file.Length <= maxFileSize;
    //}
}
