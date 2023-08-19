using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;

public class ReservaConfiguration : IEntityTypeConfiguration<Reserva>
{
    public void Configure(EntityTypeBuilder<Reserva> builder)
    {
        builder.ToTable("Reserva");

        builder.Property(p => p.ID_Reserva)
        .IsRequired();

        builder.Property(p => p.Fecha_Reserva)
        .IsRequired()
        .HasColumnType("datetime");

        builder.Property(p => p.Fecha_Inicio)
        .IsRequired()
        .HasColumnType("datetime");

        builder.Property(p => p.Fecha_Fin)
        .IsRequired()
        .HasColumnType("datetime");

        builder.Property(p => p.EStado)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(p => p.Cliente)
        .WithMany(p => p.Reservas)
        .HasForeignKey(p => p.ID_Cliente)
        .IsRequired();

        builder.HasOne(p => p.Automovil)
        .WithMany(p => p.Reservas)
        .HasForeignKey(p => p.ID_Automovil)
        .IsRequired();

    }
}
