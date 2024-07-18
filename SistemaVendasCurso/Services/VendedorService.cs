using SistemaVendasCurso.Data;
using SistemaVendasCurso.Models;

namespace SistemaVendasCurso.Services;

public class VendedorService
{
    private readonly SistemaVendasCursoContext _context;

    public VendedorService(SistemaVendasCursoContext context)
    {
        _context = context;
    }
    
    public List<Vendedor> Listar()
    {
        return _context.Vendedores.ToList();
    }
}