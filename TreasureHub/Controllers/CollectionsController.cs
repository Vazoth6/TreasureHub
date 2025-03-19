using Microsoft.AspNetCore.Mvc;

namespace TreasureHub.Controllers;

public class CollectionsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}