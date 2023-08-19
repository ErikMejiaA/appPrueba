
using System.Reflection;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistencia;

public class AppPruebaContext : DbContext
{
    public AppPruebaContext(DbContextOptions<AppPruebaContext> options) : base(options)
    {

    }


    //aqui van los DbSet<>

    public DbSet<Alquiler> ? Alquileres { get; set; }
    public DbSet<Automovil> ? Automoviles { get; set; }
    public DbSet<Cliente> ? Clientes { get; set; }
    public DbSet<Empleado> ? Empleados { get; set; }
    public DbSet<Registro_devolucion> ? Registros_devoluciones { get; set; }
    public DbSet<Registro_entrega> ? Registro_entregas { get; set; }
    public DbSet<Reserva> ? Reservas { get; set; }
    public DbSet<Sucursal_automovil> ? Sucursales_Automoviles { get; set; }
    public DbSet<Sucursal> ? Sucursales { get; set; }


    //metodo para cargar de forma automatica las entidades y configuraciones de estas en la base de datos creada
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //definimos las llaves primarias campuestas de la entida ProductoPersona. de una relacion de muchos a muchos
        modelBuilder.Entity<Sucursal_automovil>().HasKey(p => new {p.ID_Sucursal, p.ID_Automovil});

        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }


    internal void SaveAsync()
    {
        throw new NotImplementedException();
    }
}
