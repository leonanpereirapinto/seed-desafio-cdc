using FluentValidation;
using LivrariaCDC.WebAPI.Data;
using LivrariaCDC.WebAPI.Regions;

namespace LivrariaCDC.WebAPI.Authors;

public class NewContryRequestValidator : AbstractValidator<NewContryRequest> 
{
    public NewContryRequestValidator(ApplicationDbContext context)
    {
        RuleFor(a => a.Name)
            .NotEmpty()
            .Must(name => !context.Countries.Any(category => category.Name == name ))
            .WithMessage("Name already exists");
    }
}