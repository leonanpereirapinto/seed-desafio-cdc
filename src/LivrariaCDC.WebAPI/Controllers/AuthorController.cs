using LivrariaCDC.WebAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaCDC.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public AuthorController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost(Name = "PostAuthor")]
    public async Task<IActionResult> Post(NewAuthorRequest newAuthor)
    {
        await _context.AddAsync(newAuthor.ToModel());
        await _context.SaveChangesAsync();
        return Ok();
    }
}