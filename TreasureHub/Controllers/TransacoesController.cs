using Microsoft.AspNetCore.Mvc;

namespace TreasureHub.Controllers;

public class TransacoesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}