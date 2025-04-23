using Microsoft.AspNetCore.Mvc;

namespace TreasureHub.Controllers;

public class ListagensController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}