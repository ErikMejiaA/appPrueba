
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;

public class AutomovilConfiguration : IEntityTypeConfiguration<Automovil>
{
    public void Configure(EntityTypeBuilder<Automovil> builder)
    {
        builder.ToTable("Automovil");

        builder.Property(p => p.ID_Automovil)
        .IsRequired();

        builder.Property(p => p .Marca)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(p => p .Modelo)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(P => P.Anio)
        .IsRequired();

        builder.Property(p => p .Tipo)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Capasidad)
        .IsRequired();

        builder.Property(p => p.Precio_decimal)
        .IsRequired()
        .HasColumnType("decimal(10.2)");

    }
}
