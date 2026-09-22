using Microsoft.AspNetCore.Mvc;

namespace LegalConnect.Api.Controllers;

[ApiController]
[Route("api/v1/platform")]
public sealed class PlatformController : ControllerBase
{
    [HttpGet("status")]
    public IActionResult GetStatus() => Ok(new
    {
        product = "LegalConnect",
        theme = "Verdant Chamber",
        status = "scaffold-ready",
        disclaimer = "LegalConnect is a facilitation platform and does not provide legal advice."
    });
}
