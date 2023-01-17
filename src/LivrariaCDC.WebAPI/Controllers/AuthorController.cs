using LivrariaCDC.WebAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LivrariaCDC.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
// 3
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
        // 1
        if(await _context.Authors.AnyAsync(author => author.Email == newAuthor.Email)) // 1
            return BadRequest("E-mail already exists");

        await _context.AddAsync(newAuthor.ToModel());
        await _context.SaveChangesAsync();
        return Ok();
    }
}