namespace SistemaVendasCurso.Models;

public class Vendedor
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public DateTime DataNascimento { get; set; }
    public double Salario { get; set; }
    public Departamento Departamento { get; set; }
    public ICollection<Venda> Vendas { get; set; } = new List<Venda>();

    public Vendedor()
    {
    }

    public Vendedor(int id
        , string nome
        , string email
        , string senha
        , DateTime dataNascimento
        , double salario
        , Departamento departamento)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Senha = senha;
        DataNascimento = dataNascimento;
        Salario = salario;
        Departamento = departamento;
    }
    
    public void AddVenda(Venda venda)
    {
        Vendas.Add(venda);
    }
    
    public void RemoveVenda(Venda venda)
    {
        Vendas.Remove(venda);
    }
    
    public double TotalVendas(DateTime inicio, DateTime fim)
    {
        return Vendas
            .Where(v => v.DataVenda >= inicio && v.DataVenda <= fim)
            .Sum(v => v.Total);
    }
}