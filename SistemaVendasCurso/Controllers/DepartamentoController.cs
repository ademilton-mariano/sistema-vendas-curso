using Microsoft.AspNetCore.Mvc;
using SistemaVendasCurso.Models;

namespace SistemaVendasCurso.Controllers;

public class DepartamentoController : Controller
{
    public IActionResult Index()
    {
        List<Departamento> list = new()
        {
            new Departamento { Id = 1, Nome = "Eletrônicos" },
            new Departamento { Id = 2, Nome = "Alimentos" },
            new Departamento { Id = 3, Nome = "Moda" }
        };
        return View(list);
    }
}