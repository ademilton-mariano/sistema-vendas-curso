using Microsoft.EntityFrameworkCore;
using SistemaVendasCurso.Models;

namespace SistemaVendasCurso.Data;

public class SistemaVendasCursoContext : DbContext
{
    public SistemaVendasCursoContext (DbContextOptions<SistemaVendasCursoContext> options)
        : base(options)
    {
    }

    public DbSet<Departamento> Departamento { get; set; } = default!;
}