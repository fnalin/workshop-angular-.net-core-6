using FN.WorkShopNetCoreAngular.Domain.Entities;

namespace FN.WorkShopNetCoreAngular.API.Models;

public class ClientesList
{
    public int Id { get; set; }
    public string? NomeCompleto { get; set; }
    public DateTime Nascimento { get; set; }
    public DateTime CriadoEm { get; set; }
    public string? Sexo { get; set; }
    
    public static implicit operator ClientesList(Cliente data)  
    {  
        return new ClientesList()  
        {  
            Id = data.Id,
            NomeCompleto = $"{data.Nome} {data.Sobrenome}",
            Nascimento = data.Nascimento,
            Sexo = Enum.GetName(data.Sexo),
            CriadoEm = data.CriadoEm
        };  
    } 
}

public class ClienteCtrlV1ModelExtension
{

    
}

