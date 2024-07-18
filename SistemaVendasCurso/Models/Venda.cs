using SistemaVendasCurso.Models.Enums;

namespace SistemaVendasCurso.Models;

public class Venda
{
    public int Id { get; set; }
    public DateTime DataVenda { get; set; }
    public double Total { get; set; }
    public StatusVenda StatusVenda { get; set; }
    public Vendedor Vendedor { get; set; }
    
    public Venda()
    {
    }
    
    public Venda(int id
        , DateTime dataVenda
        , double total
        , StatusVenda statusVenda
        , Vendedor vendedor)
    {
        Id = id;
        DataVenda = dataVenda;
        Total = total;
        StatusVenda = statusVenda;
        Vendedor = vendedor;
    }
    
    public void SetStatusVenda(StatusVenda status)
    {
        StatusVenda = status;
    }
    
    public override string ToString()
    {
        return $"Id: {Id}, Data: {DataVenda}, Total: {Total}, Status: {StatusVenda}";
    }
}