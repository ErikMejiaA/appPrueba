
namespace Dominio.Entities;

public class Sucursal_automovil
{
    public int ID_Sucursal { get; set; }
    public int ID_Automovil { get; set; }
    public int Cantidad_Disponible { get; set; }

    public Sucursal ? Sucursal { get; set; }
    public Automovil ? Automovil { get; set; }
        
}
