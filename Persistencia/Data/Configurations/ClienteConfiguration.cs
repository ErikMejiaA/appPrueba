
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Cliente");

        builder.Property(p => p.ID_Cliente)
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

        builder.Property(p => p.Email)
        .IsRequired()
        .HasMaxLength(100);

    }
}
