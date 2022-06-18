using FN.WorkShopNetCoreAngular.Domain.Contracts.Repositories;
using Microsoft.AspNetCore.Mvc;
using FN.WorkShopNetCoreAngular.API.Models;
using FN.WorkShopNetCoreAngular.Domain.Contracts.Infra;
using FN.WorkShopNetCoreAngular.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FN.WorkShopNetCoreAngular.API.Controllers.v1;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class ClientesController : ControllerBase
{
    private readonly IClienteRepository _clienteRepository;
    private readonly IUnitOfWork _uow;

    public ClientesController(
        IClienteRepository clienteRepository,
        IUnitOfWork uow)
    {
        _clienteRepository = clienteRepository;
        _uow = uow;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var data = await _clienteRepository.GetAsync();
        var model = data.Select(d=>(ClienteModel)d);
        return Ok(model);
    }

    [HttpGet("{id:int}", Name = "GetClienteById")]
    public async Task<IActionResult> GetById(int id)
    {
        var data = (Cliente) await _clienteRepository.GetAsync(id);

        if (data is null) return NotFound();
        
        ClienteModel model = data;
        return Ok(model);
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody]ClienteAddModel command)
    {

        if (!ModelState.IsValid) return BadRequest(ModelState);

        Cliente data = command;
        _clienteRepository.Add(data);

        await _uow.CommitAsync();

        return CreatedAtRoute("GetClienteById", new {data.Id}, (ClienteModel)data );
    }
    
    [HttpPut("{id:int}")]
    public async Task<IActionResult> Edit(int id, [FromBody]ClienteEditModel command)
    {
        if (id != command.Id) ModelState.AddModelError("id", "Os ids não conferem");
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var data = (Cliente)await _clienteRepository.GetAsync(id);
        data.Update(command.Nome, command.Sobrenome, command.Nascimento);
        _clienteRepository.Edit(data);

        await _uow.CommitAsync();

        return NoContent();
    }
    
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var cliente = (Cliente)await _clienteRepository.GetAsync(id);
            
        if (cliente == null) {
            ModelState.AddModelError("id", "cliente não localizado");
            return BadRequest(ModelState);
        }

        _clienteRepository.Delete(cliente);
        await _uow.CommitAsync();
        return NoContent();

    }


}