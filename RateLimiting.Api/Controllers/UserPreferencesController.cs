using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RateLimiting.Api;

[ApiController]
[Route("api/public/[controller]")]
public class UserPreferencesController : ControllerBase
{
    [HttpGet("lang")]
    public async Task<IActionResult> GetLanguageAsync()
    {
        Console.WriteLine("User preference controller call received.");
        
        await Task.Delay(1000);
        return Ok("English");
    }
}