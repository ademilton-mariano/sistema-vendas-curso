using SistemaVendasCurso.Models.Enums;

namespace SistemaVendasCurso.Models;

public class Venda
{
    public int Id { get; set; }
    public DateTime DataVenda { get; set; }
    public double Total { get; set; }
    public StatusVenda Status { get; set; }
    public Vendedor Vendedor { get; set; }
    
    public Venda()
    {
    }
    
    public Venda(int id
        , DateTime dataVenda
        , double total
        , StatusVenda status
        , Vendedor vendedor)
    {
        Id = id;
        DataVenda = dataVenda;
        Total = total;
        Status = status;
        Vendedor = vendedor;
    }
    
    public void SetStatusVenda(StatusVenda status)
    {
        Status = status;
    }
    
    public override string ToString()
    {
        return $"Id: {Id}, Data: {DataVenda}, Total: {Total}, Status: {Status}";
    }
}