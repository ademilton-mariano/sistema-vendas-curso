﻿namespace SistemaVendasCurso.Models;

public class Departamento
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();
    
    public Departamento()
    {
    }
    
    public Departamento(int id
        , string nome)
    {
        Id = id;
        Nome = nome;
    }
    
    public void AddVendedor(Vendedor vendedor)
    {
        Vendedores.Add(vendedor);
    }
    
    public void RemoveVendedor(Vendedor vendedor)
    {
        Vendedores.Remove(vendedor);
    }
    
    public double TotalVendas(DateTime inicio, DateTime fim)
    {
        return Vendedores
            .Sum(v => v.TotalVendas(inicio, fim));
    }
    
}