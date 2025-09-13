using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HomeController : Controller
{
    // 
    // GET: /
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /Welcome/
    // Requires using System.Text.Encodings.Web;
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}