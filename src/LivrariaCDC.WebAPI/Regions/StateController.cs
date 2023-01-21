using LivrariaCDC.WebAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaCDC.WebAPI.Regions;

[ApiController]
[Route("[controller]")]
public class StateController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public StateController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost(Name = "PostState")]
    public async Task<IActionResult> Post(NewStateRequest newState) // 1
    {
        await _context.States.AddAsync(newState.ToModel());
        await _context.SaveChangesAsync();
        return Ok();
    }
}
