using FluentValidation;
using LivrariaCDC.WebAPI.Data;
using LivrariaCDC.WebAPI.Regions;

namespace LivrariaCDC.WebAPI.Authors;

public class NewStateRequestValidator : AbstractValidator<NewStateRequest> 
{
    public NewStateRequestValidator(ApplicationDbContext context)
    {
        RuleFor(a => a.CountryId)
            .NotEmpty()
            .Must(id => context.Countries.Any(c => c.Id == id))
            .WithMessage("Country not found");

        RuleFor(a => a.Name)
            .NotEmpty()
            .Must(name => !context.States.Any(state => state.Name == name ))
            .WithMessage("Name already exists");
    }
}