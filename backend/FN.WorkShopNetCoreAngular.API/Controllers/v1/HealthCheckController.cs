using Microsoft.AspNetCore.Mvc;

namespace FN.WorkShopNetCoreAngular.API.Controllers.v1;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class HealthCheckController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("v1");
}