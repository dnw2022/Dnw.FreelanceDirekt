using Microsoft.AspNetCore.Mvc;

namespace Dnw.FreelanceDirekt.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}