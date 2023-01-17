using LivrariaCDC.WebAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LivrariaCDC.WebAPI.Categories;

[ApiController]
[Route("[controller]")]
// 3
public class CategoryController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public CategoryController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost(Name = "PostAuthor")]
    public async Task<IActionResult> Post(NewCategoryRequest newCategory) // 1
    {
        // 1
        if (await _context.Categories.AnyAsync(author => author.Name == newCategory.Name)) // 1
            return BadRequest("Category already exists");

        await _context.AddAsync(newCategory.ToModel());
        await _context.SaveChangesAsync();
        return Ok();
    }
}
