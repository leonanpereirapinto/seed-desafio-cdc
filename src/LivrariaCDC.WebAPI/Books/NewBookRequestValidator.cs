using FluentValidation;
using LivrariaCDC.WebAPI.Data;

namespace LivrariaCDC.WebAPI.Books;

public class NewBookRequestValidator : AbstractValidator<NewBookRequest> 
{
    public NewBookRequestValidator(ApplicationDbContext context)
    {
        RuleFor(a => a.Title)
            .NotEmpty()
            .Must(title => !context.Books.Any(b => b.Title == title))
            .WithMessage("Title already exists");

        RuleFor(a => a.Resume)
            .MaximumLength(500);

        RuleFor(a => a.Price)
            .NotEmpty()
            .GreaterThan(20);

        RuleFor(a => a.Pages)
            .NotEmpty()
            .GreaterThan(100);

        RuleFor(a => a.Isbn)
            .NotEmpty()
            .Must(isbn => !context.Books.Any(b => b.Isbn == isbn))
            .WithMessage("Isbn already exists");

        RuleFor(a => a.ReleaseDate)
            .NotEmpty()
            .GreaterThan(DateTime.Now);

        RuleFor(a => a.CategoryId)
            .NotEmpty()
            .Must(id => context.Categories.Any(c => c.Id == id))
            .WithMessage("Category not found");

        RuleFor(a => a.AuthorId)
            .NotEmpty()
            .Must(id => context.Authors.Any(a => a.Id == id))
            .WithMessage("Author not found");
    }
}