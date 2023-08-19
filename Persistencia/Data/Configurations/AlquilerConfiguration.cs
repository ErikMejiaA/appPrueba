
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Data.Configurations;

public class AlquilerConfiguration : IEntityTypeConfiguration<Alquiler>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Alquiler> builder)
    {
        builder.ToTable("Alquiler");

        builder.Property(p => p.ID_Alquiler)
        .IsRequired();

        builder.Property(p => p.Fecha_Inicio)
        .IsRequired()
        .HasColumnType("datetime");


        builder.Property(p => p.Fecha_Fin)
        .IsRequired()
        .HasColumnType("datetime");

        builder.Property(p => p.Costo_Total)
        .IsRequired()
        .HasColumnType("decimal(10.2)");

        builder.Property(p => p.Estado)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(p => p.Cliente)
        .WithMany(p => p.Alquileres)
        .HasForeignKey(p => p.ID_Cliente)
        .IsRequired();

        builder.HasOne(p => p.Automovil)
        .WithMany(p => p.Alquileres)
        .HasForeignKey(p => p.ID_Automovil)
        .IsRequired();

    }
}
