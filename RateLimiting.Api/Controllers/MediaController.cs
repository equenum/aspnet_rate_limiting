using System;
using Microsoft.AspNetCore.Mvc;

namespace RateLimiting.Api;

[ApiController]
[Route("api/public/[controller]")]
public class MediaController : ControllerBase
{
    [HttpGet("stream")]
    public IActionResult GetMediaStream()
    {
        Console.WriteLine("Media controller call received.");

        var bytes = new byte[100];
        
        var random = new Random();
        random.NextBytes(bytes);

        return Ok(string.Join(" ", bytes));
    }
}
