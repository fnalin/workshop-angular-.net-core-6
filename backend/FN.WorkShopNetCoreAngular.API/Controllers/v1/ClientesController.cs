using FN.WorkShopNetCoreAngular.Domain.Contracts.Repositories;
using Microsoft.AspNetCore.Mvc;
using FN.WorkShopNetCoreAngular.API.Models;
using FN.WorkShopNetCoreAngular.Domain.Entities;

namespace FN.WorkShopNetCoreAngular.API.Controllers.v1;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class ClientesController : ControllerBase
{
    private readonly IClienteRepository _clienteRepository;

    public ClientesController(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var data = await _clienteRepository.GetAsync();
        var model = data.Select(d=>(ClientesList)d);
        return Ok(model);
    }
}