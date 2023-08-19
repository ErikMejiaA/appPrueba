
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class ReservaRepository : GenericRepositoryA<Reserva>, IReservaInterface
{
    private readonly AppPruebaContext _context;

    public ReservaRepository(AppPruebaContext context) : base(context)
    {
        _context = context;
    }

    //nuevos metodos (override)
}
