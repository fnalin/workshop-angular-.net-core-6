using System.Globalization;
using FN.WorkShopNetCoreAngular.Domain.Enums;

namespace FN.WorkShopNetCoreAngular.Domain.Entities;

public class Cliente :  Entity
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public Sexo Sexo { get; set; }
    public DateTime Nascimento { get; set; }
    public DateTime CriadoEm { get; set; } = DateTime.UtcNow;

    public void Update(string nome, string sobrenome, DateTime nascimento)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        Nascimento = nascimento;
    }
}