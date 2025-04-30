using Microsoft.AspNetCore.Mvc;

namespace TreasureHub.Controllers;

public class ItensController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}