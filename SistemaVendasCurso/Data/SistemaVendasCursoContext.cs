using Microsoft.EntityFrameworkCore;
using SistemaVendasCurso.Models;

namespace SistemaVendasCurso.Data;

public class SistemaVendasCursoContext : DbContext
{
    public SistemaVendasCursoContext (DbContextOptions<SistemaVendasCursoContext> options)
        : base(options)
    {
    }

    public DbSet<Departamento> Departamentos { get; set; }
    public DbSet<Vendedor> Vendedores { get; set; }
    public DbSet<Venda> Vendas { get; set; }
}