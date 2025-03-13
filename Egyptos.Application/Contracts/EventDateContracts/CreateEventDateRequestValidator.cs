using Egyptos.Application.Contracts.Event;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using static System.Net.Mime.MediaTypeNames;

namespace Egyptos.Application.Contracts.EventDateContracts;

public class CreateEventDateRequestValidator : AbstractValidator<CreateEventDateRequest>
{
    public CreateEventDateRequestValidator()
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

        RuleFor(x => x.EventId)
            .NotEmpty();

        //RuleFor(s => s.Images)
        //    .NotNull()
        //    .Must(ValidateFile)
        //    .WithMessage("Invalid file. Allowed file types are .jpg, .jpeg, .png, and max size is 5MB.");

        RuleFor(x => x)
               .Must(HasValidDates)
               .WithName(nameof(CreateEventDateRequest.EndDate))
               .WithMessage("{PropertyName} must be grater than or equal start date");

        RuleFor(x => x)
               .Must(HasValidSubscription)
               .WithName(nameof(CreateEventDateRequest.EndSubscription))
               .WithMessage("{PropertyName} must be grater than or equal start subscription");
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

    private bool HasValidDates(CreateEventDateRequest request) =>
        request.StartDate <= request.EndDate;

    private bool HasValidSubscription(CreateEventDateRequest request) =>
        request.StartSubscription <= request.EndSubscription;

}