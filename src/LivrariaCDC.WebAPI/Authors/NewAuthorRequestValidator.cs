using FluentValidation;
using LivrariaCDC.WebAPI.Data;

namespace LivrariaCDC.WebAPI.Authors;

public class NewAuthorRequestValidator : AbstractValidator<NewAuthorRequest> 
{
    public NewAuthorRequestValidator(ApplicationDbContext context)
    {
        RuleFor(a => a.Name).NotEmpty();

        RuleFor(a => a.Email)
            .NotEmpty()
            .EmailAddress()
            .Must(email => !context.Authors.Any(author => author.Email == email))
            .WithMessage("Email already exists");

        RuleFor(a => a.Description)
            .NotEmpty()
            .MaximumLength(400);

    }
}