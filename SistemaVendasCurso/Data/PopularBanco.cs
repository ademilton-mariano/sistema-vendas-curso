using Microsoft.EntityFrameworkCore;
using SistemaVendasCurso.Models;
using SistemaVendasCurso.Models.Enums;

namespace SistemaVendasCurso.Data;

public class PopularBanco
{
    private readonly SistemaVendasCursoContext _context;

    public PopularBanco(SistemaVendasCursoContext context)
    {
        _context = context;
    }

    public void Popular()
    {
        if (_context.Departamentos.Any() || _context.Vendedores.Any() || _context.Vendas.Any())
        {
            return; 
        }

        var departamento1 = new Departamento(1, "Eletrônicos");
        var departamento2 = new Departamento(2, "Moda");
        var departamento3 = new Departamento(3, "Livros");
        var departamento4 = new Departamento(4, "Computadores");

        var vendedor1 = new Vendedor(1, "João", "joao@email.com", "123456", new DateTime(1992, 02, 13), 1000.0,
            departamento1);
        var vendedor2 = new Vendedor(2, "Maria", "maria@email.com", "123456", new DateTime(1993, 03, 10), 1100.0,
            departamento2);
        var vendedor3 = new Vendedor(3, "Ana", "ana@email.com", "123456", new DateTime(1994, 04, 11), 1200.0,
            departamento3);
        var vendedor4 = new Vendedor(4, "Pedro", "pedro@email.com", "123456", new DateTime(1995, 05, 12), 1300.0,
            departamento4);
        var vendedor5 = new Vendedor(5, "Paulo", "paulo@email.com", "123456", new DateTime(1996, 06, 14), 1400.0,
            departamento1);
        var vendedor6 = new Vendedor(6, "Lucas", "lucas@email.com", "123456", new DateTime(1997, 07, 15), 1500.0,
            departamento2);

        var venda1 = new Venda(1, new DateTime(2021, 10, 20), 1000.0, StatusVenda.Faturado, vendedor1);
        var venda2 = new Venda(2, new DateTime(2021, 10, 21), 2000.0, StatusVenda.Faturado, vendedor2);
        var venda3 = new Venda(3, new DateTime(2021, 10, 22), 3000.0, StatusVenda.Faturado, vendedor3);
        var venda4 = new Venda(4, new DateTime(2021, 10, 23), 4000.0, StatusVenda.Faturado, vendedor4);
        var venda5 = new Venda(5, new DateTime(2021, 10, 24), 5000.0, StatusVenda.Faturado, vendedor5);
        var venda6 = new Venda(6, new DateTime(2021, 10, 25), 6000.0, StatusVenda.Faturado, vendedor6);
        var venda7 = new Venda(7, new DateTime(2021, 10, 26), 7000.0, StatusVenda.Cancelado, vendedor1);
        var venda8 = new Venda(8, new DateTime(2021, 10, 27), 8000.0, StatusVenda.Cancelado, vendedor2);
        var venda9 = new Venda(9, new DateTime(2021, 10, 28), 9000.0, StatusVenda.Cancelado, vendedor3);
        var venda10 = new Venda(10, new DateTime(2021, 10, 29), 10000.0, StatusVenda.Cancelado, vendedor4);
        var venda11 = new Venda(11, new DateTime(2021, 10, 30), 11000.0, StatusVenda.Cancelado, vendedor5);
        var venda12 = new Venda(12, new DateTime(2021, 10, 31), 12000.0, StatusVenda.Cancelado, vendedor6);
        var venda13 = new Venda(13, new DateTime(2021, 11, 01), 13000.0, StatusVenda.Pendente, vendedor1);
        var venda14 = new Venda(14, new DateTime(2021, 11, 02), 14000.0, StatusVenda.Pendente, vendedor2);
        var venda15 = new Venda(15, new DateTime(2021, 11, 03), 15000.0, StatusVenda.Pendente, vendedor3);
        var venda16 = new Venda(16, new DateTime(2021, 11, 04), 16000.0, StatusVenda.Pendente, vendedor4);
        var venda17 = new Venda(17, new DateTime(2021, 11, 05), 17000.0, StatusVenda.Pendente, vendedor5);
        var venda18 = new Venda(18, new DateTime(2021, 11, 06), 18000.0, StatusVenda.Pendente, vendedor6);
        
        _context.Departamentos.AddRange(departamento1, departamento2, departamento3, departamento4);
        _context.Vendedores.AddRange(vendedor1, vendedor2, vendedor3, vendedor4, vendedor5, vendedor6);
        _context.Vendas.AddRange(venda1, venda2, venda3, venda4, venda5, venda6, venda7, venda8, venda9, venda10,
            venda11, venda12, venda13, venda14, venda15, venda16, venda17, venda18);
        
        _context.SaveChanges();
    }
    
}