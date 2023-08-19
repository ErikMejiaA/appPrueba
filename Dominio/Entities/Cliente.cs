
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;

public class Cliente
{
    [Key]
    public int ID_Cliente { get; set; }
    public string ? Nombre { get; set; }
    public string ? Apellido { get; set; }
    public string ? DNI { get; set; }
    public string ? Direccion { get; set; }
    public string ? Telefono { get; set; }
    public string ? Email { get; set; }

    public ICollection<Reserva> ? Reservas { get; set; }
    public ICollection<Alquiler> ? Alquileres { get; set; }

        
}
