using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TALLY_APP.Models;

namespace TALLY_APP.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View("~/Views/Dashboard/index.cshtml");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

