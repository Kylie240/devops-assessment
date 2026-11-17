using Microsoft.AspNetCore.Mvc;

[ApiController]
public class VersionController : ControllerBase
{
    [HttpGet("version")]
    public IActionResult Version()
    {
        string version = Environment.GetEnvironmentVariable("APP_VERSION") ?? "dev";
        return Ok(version);
    }
}
