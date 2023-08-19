
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;

public class Alquiler
{
    [Key]
    public int ID_Alquiler { get; set; }
    public int ID_Cliente { get; set; }
    public int ID_Automovil { get; set; }
    public DateTime Fecha_Inicio { get; set; }
    public DateTime Fecha_Fin { get; set; }
    public decimal Costo_Total { get; set; }
    public string ? Estado { get; set; }

    public Automovil ? Automovil { get; set; }
    public Cliente ? Cliente { get; set; }

    public ICollection<Registro_devolucion> ? Registros_devoluciones { get; set; }

    public ICollection<Registro_entrega> ? Registros_entregas { get; set; }


}
