
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class AutomovilRepository : GenericRepositoryA<Automovil>, IAutomovilInterface
{
    private readonly AppPruebaContext _context;

    public AutomovilRepository(AppPruebaContext context) : base(context)
    {
        _context = context;
    }

    //nuevos metodos (override)
}
