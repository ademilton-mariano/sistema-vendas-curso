using Microsoft.AspNetCore.Mvc;
using SistemaVendasCurso.Services;

namespace SistemaVendasCurso.Controllers;

public class VendedorController : Controller
{
    private readonly VendedorService _vendedorService;

    public VendedorController(VendedorService vendedorService)
    {
        _vendedorService = vendedorService;
    }

    public IActionResult Index()
    {
        var vendedores = _vendedorService.Listar();
        return View(vendedores);
    }
}