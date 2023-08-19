
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;

public class Sucursal
{
    [Key]
    public int ID_Sucursal { get; set; }
    public string ? Nombre { get; set; }
    public string ? Direccion { get; set; }
    public string ? Telefono { get; set; }

    public ICollection<Sucursal_automovil> ? Sucursales_automoviles { get; set; }
        
}
