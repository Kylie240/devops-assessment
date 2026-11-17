using Microsoft.AspNetCore.Mvc;

[ApiController]
public class HealthController : ControllerBase
{
    [HttpGet("health")]
    public IActionResult Health() => Ok(new
    {
        status = "healthy",
        service = "HealthService",
        provider = "United Health",
        timestamp = DateTime.UtcNow
    });
}
