
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;

public class Empleado
{
    [Key]
    public int ID_Empleado { get; set; }
    public string ? Nombre  { get; set; }
    public string ? Apellido { get; set; }
    public string ? DNI { get; set; }
    public string ? Direccion { get; set; }
    public string ? Telefono { get; set; }
    public string ? Cargo { get; set; }

    public ICollection<Registro_devolucion> ? Registros_Devoluciones { get; set; }
    public ICollection<Registro_entrega> ? Registros_Entregas { get; set; }
        
}
