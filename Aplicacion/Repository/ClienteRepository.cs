
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class ClienteRepository : GenericRepositoryA<Cliente>, IClienteInterface
{
    private readonly AppPruebaContext _context;

    public ClienteRepository(AppPruebaContext context) : base(context)
    {
        _context = context;
    }

    //nuevos metodos (override)
}
