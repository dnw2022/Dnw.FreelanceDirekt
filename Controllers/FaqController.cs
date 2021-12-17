using Microsoft.AspNetCore.Mvc;

namespace Dnw.FreelanceDirekt.Controllers;

public class FaqController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}