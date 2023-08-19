
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;

public class Automovil
{
    [Key]
    public int ID_Automovil { get; set; }
    public string ? Marca { get; set; }
    public string ? Modelo { get; set; }
    public int Anio { get; set; }
    public string ? Tipo { get; set; }
    public int Capasidad { get; set; }
    public decimal Precio_decimal { get; set; }


        public ICollection<Sucursal_automovil> ? Sucursales_automoviles { get; set; }

        public ICollection<Reserva> ? Reservas{ get; set; }
        public ICollection<Alquiler> ? Alquileres { get; set; }
}
