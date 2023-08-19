
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;

public class SucursalConfiguration : IEntityTypeConfiguration<Sucursal>
{
    public void Configure(EntityTypeBuilder<Sucursal> builder)
    {
        builder.ToTable("Sucursal");

        builder.Property(p => p.ID_Sucursal)
        .IsRequired();

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(p => p.Direccion)
        .IsRequired()
        .HasMaxLength(255);

        builder.Property(p => p.Telefono)
        .IsRequired()
        .HasMaxLength(20);


    }
}
