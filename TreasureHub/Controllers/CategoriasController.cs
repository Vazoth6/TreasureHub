using Microsoft.AspNetCore.Mvc;

namespace TreasureHub.Controllers;

public class CategoriasController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}