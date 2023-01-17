using FluentValidation;
using LivrariaCDC.WebAPI.Categories;
using LivrariaCDC.WebAPI.Data;

namespace LivrariaCDC.WebAPI.Authors;

public class NewCategoryRequestValidator : AbstractValidator<NewCategoryRequest> 
{
    public NewCategoryRequestValidator(ApplicationDbContext context)
    {
        RuleFor(a => a.Name)
            .NotEmpty()
            .Must(name => !context.Categories.Any(category => category.Name == name ))
            .WithMessage("Name already exists");
    }
}