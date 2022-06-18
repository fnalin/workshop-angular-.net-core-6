using System.ComponentModel.DataAnnotations;
using FN.WorkShopNetCoreAngular.Domain.Entities;
using FN.WorkShopNetCoreAngular.Domain.Enums;

namespace FN.WorkShopNetCoreAngular.API.Models;

public class ClienteAddModel
{
    
    [Required(ErrorMessage = "O {0} é obrigatório")]
    [StringLength(80, ErrorMessage = "Atingido o limite de {1} caracteres em {0}")]
    public string Nome { get; set; }
    
    [Required(ErrorMessage = "O {0} é obrigatório")]
    [StringLength(80, ErrorMessage = "Atingido o limite de {1} caracteres em {0}")]
    public string Sobrenome { get; set; }
    public DateTime Nascimento { get; set; }
    
    [EnumDataType(typeof(Sexo), ErrorMessage = "{0} inválido")] 
    public int Sexo { get; set; }
    
    public static implicit operator Cliente(ClienteAddModel model)
    {
       return new Cliente()  
        {  
            Id = 0,
            Nome = model.Nome,
            Sobrenome = model.Sobrenome,
            Nascimento = model.Nascimento,
            Sexo = (Sexo)model.Sexo
        };  
    }
}


public class ClienteEditModel
{

    public int Id { get;  set; }
    [Required(ErrorMessage = "O {0} é obrigatório")]
    [StringLength(80, ErrorMessage = "Atingido o limite de {1} caracteres em {0}")]
    public string Nome { get; set; }
    
    [Required(ErrorMessage = "O {0} é obrigatório")]
    [StringLength(80, ErrorMessage = "Atingido o limite de {1} caracteres em {0}")]
    public string Sobrenome { get; set; }
    public DateTime Nascimento { get; set; }
    
}


public class ClienteModel
{
    public int Id { get; set; }
    public string? NomeCompleto { get; set; }
    public DateTime Nascimento { get; set; }
    public DateTime CriadoEm { get; set; }
    public string? Sexo { get; set; }
    
    public static implicit operator ClienteModel(Cliente? data)
    {
        if (data is null) return null;
        
        return new ClienteModel()  
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

