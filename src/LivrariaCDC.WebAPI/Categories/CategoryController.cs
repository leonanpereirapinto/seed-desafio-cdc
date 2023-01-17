using LivrariaCDC.WebAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LivrariaCDC.WebAPI.Categories;

[ApiController]
[Route("[controller]")]
// 1
public class CategoryController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public CategoryController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost(Name = "PostCategory")]
    public async Task<IActionResult> Post(NewCategoryRequest newCategory) // 1
    {
        await _context.AddAsync(newCategory.ToModel());
        await _context.SaveChangesAsync();
        return Ok();
    }
}
