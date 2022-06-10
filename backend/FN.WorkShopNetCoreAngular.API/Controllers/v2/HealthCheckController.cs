using Microsoft.AspNetCore.Mvc;

namespace FN.WorkShopNetCoreAngular.API.Controllers.v2;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("2.0")]
public class HealthCheckController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("v2");
}