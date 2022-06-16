using FN.WorkShopNetCoreAngular.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FN.WorkShopNetCoreAngular.Data.EF.Maps;

public class ClienteMap : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable(nameof(Cliente));
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).ValueGeneratedOnAdd();

        builder.Property(c => c.Nome)
            .IsRequired()
            .HasColumnType("varchar(80)");
        
        builder.Property(c => c.Sobrenome)
            .IsRequired()
            .HasColumnType("varchar(80)");
        
        builder.Property(c => c.Sexo)
            .IsRequired()
            .HasColumnType("tinyint");
        
        builder.Property(c => c.Nascimento)
            .IsRequired()
            .HasColumnType("datetime2");
        
        builder.Property(c => c.CriadoEm)
            .IsRequired()
            .HasColumnType("datetime2");
    }
}