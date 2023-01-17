using LivrariaCDC.WebAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LivrariaCDC.WebAPI.Authors;

[ApiController]
[Route("[controller]")]
// 1
public class AuthorController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public AuthorController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost(Name = "PostAuthor")]
    public async Task<IActionResult> Post(NewAuthorRequest newAuthor) // 1
    {
        await _context.AddAsync(newAuthor.ToModel());
        await _context.SaveChangesAsync();
        return Ok();
    }
}