using Microsoft.AspNetCore.Mvc;
namespace Aseel.Controllers;
public class ServicesController : Controller
{
    public IActionResult services()
    {
        return View();
    }
}