using Microsoft.AspNetCore.Mvc;

namespace TreasureHub.Controllers;

public class UtilizadoresController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}