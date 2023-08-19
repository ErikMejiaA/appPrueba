
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;

public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
{
    public void Configure(EntityTypeBuilder<Empleado> builder)
    {
        builder.ToTable("Empleado");

        builder.Property(p => p.ID_Empleado)
        .IsRequired();

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(p => p.Apellido)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(p => p.DNI)
        .IsRequired()
        .HasMaxLength(20);

        builder.Property(p => p.Direccion)
        .IsRequired()
        .HasMaxLength(255);

        builder.Property(p => p.Telefono)
        .IsRequired()
        .HasMaxLength(20);

        builder.Property(p => p.Cargo)
        .IsRequired()
        .HasMaxLength(50);

        
    }
}
