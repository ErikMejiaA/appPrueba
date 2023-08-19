
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;

public class Registro_entregaConfiguration : IEntityTypeConfiguration<Registro_entrega>
{
    public void Configure(EntityTypeBuilder<Registro_entrega> builder)
    {
        builder.ToTable("Registro_entrega");

        builder.Property(p => p.ID_Registro)
        .IsRequired();

        builder.Property(p => p.Fecha_Entrega)
        .IsRequired()
        .HasColumnType("datetime");

        builder.Property(p => p.Combustible_Entregado)
        .IsRequired()
        .HasColumnType("decimal(5.2)");

        builder.Property(p => p.Kilometraje_Entregado)
        .IsRequired();

        builder.HasOne(p => p.Alquiler)
        .WithMany(p => p.Registros_entregas)
        .HasForeignKey(p => p.ID_Alquiler)
        .IsRequired();

        builder.HasOne(p => p.Empleado)
        .WithMany(p => p.Registros_Entregas)
        .HasForeignKey(p => p.ID_Empleado)
        .IsRequired();
    }
}
