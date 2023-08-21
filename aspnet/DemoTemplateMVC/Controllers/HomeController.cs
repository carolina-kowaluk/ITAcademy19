using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoTemplateMVC.Models;

namespace DemoTemplateMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    //Views/Home/Index.cshtml
    public IActionResult Index() //GET .../Home/Index 
    {
        return View();
    }
    //Views/Home/Privacy.cshtml
    public IActionResult Privacy() //GET .../Home/Privacy
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() //GET .../Home/Error
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
