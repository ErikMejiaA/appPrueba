
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;

public class Registro_devolucionConfiguration : IEntityTypeConfiguration<Registro_devolucion>
{
    public void Configure(EntityTypeBuilder<Registro_devolucion> builder)
    {
        builder.ToTable("Registro_devolucion");

        builder.Property(p => p.ID_Registro)
        .IsRequired();

        builder.Property(p => p.Fecha_Devolucion)
        .IsRequired()
        .HasColumnType("datetime");

        builder.Property(p => p.Combustible_Devuelto)
        .IsRequired()
        .HasColumnType("decimal(5.2)");

        builder.Property(p => p.Kilometraje_Devuelto)
        .IsRequired();

        builder.Property(p => p.Monto_Adicional)
        .IsRequired()
        .HasColumnType("decimal(10.2)");

        builder.HasOne(p => p.Alquiler)
        .WithMany(p => p.Registros_devoluciones)
        .HasForeignKey(p => p.ID_Alquiler)
        .IsRequired();

        builder.HasOne(p => p.Empleado)
        .WithMany(p => p.Registros_Devoluciones)
        .HasForeignKey(p => p.ID_Empleado)
        .IsRequired();

    }
}
