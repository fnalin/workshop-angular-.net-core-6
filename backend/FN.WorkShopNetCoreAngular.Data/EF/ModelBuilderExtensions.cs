using FN.WorkShopNetCoreAngular.Domain.Entities;
using FN.WorkShopNetCoreAngular.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace FN.WorkShopNetCoreAngular.Data.EF;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>().HasData(getClientes);
    }
    
    private static Cliente[] getClientes =>
        new Cliente[]
        {
            new()
            {
                Id = 1, 
                Nome = "José", 
                Sobrenome = "Silva", 
                Nascimento = new DateTime(1979,9,12),
                Sexo = Sexo.Masculino
            },
            new()
            {
                Id = 2, 
                Nome = "Maria", 
                Sobrenome = "Pereira", 
                Nascimento = new DateTime(1978,6,9),
                Sexo = Sexo.Feminino
            },
            new()
            {
                Id = 3, 
                Nome = "João", 
                Sobrenome = "Costa", 
                Nascimento = new DateTime(1999,8,20),
                Sexo = Sexo.Masculino
            },
        };
}