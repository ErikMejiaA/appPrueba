
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;

public class Sucursal_automovilConfiguration : IEntityTypeConfiguration<Sucursal_automovil>
{
    public void Configure(EntityTypeBuilder<Sucursal_automovil> builder)
    {
        builder.ToTable("Sucursal_automovil");

        builder.Property(p => p .Cantidad_Disponible)
        .IsRequired();

        builder.HasOne(p => p.Sucursal)
        .WithMany(p => p.Sucursales_automoviles)
        .HasForeignKey(p => p.ID_Sucursal)
        .IsRequired();

        builder.HasOne(p => p.Automovil)
        .WithMany(p => p.Sucursales_automoviles)
        .HasForeignKey(p => p.ID_Automovil)
        .IsRequired();
    }
}
