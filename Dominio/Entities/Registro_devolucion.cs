
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.RateLimiting;

namespace Dominio.Entities;

public class Registro_devolucion
{
    [Key]
    public int ID_Registro { get; set; }
    public int ID_Alquiler { get; set; }
    public int ID_Empleado { get; set; }
    public DateTime Fecha_Devolucion { get; set; }
    public decimal Combustible_Devuelto { get; set; }
    public int Kilometraje_Devuelto { get; set; }
    public decimal Monto_Adicional { get; set; }

    public Alquiler ? Alquiler { get; set; }
    public Empleado ? Empleado { get; set; }
        
}
