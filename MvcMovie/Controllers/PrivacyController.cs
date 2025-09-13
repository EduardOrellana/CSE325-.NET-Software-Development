using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class Privacy : Controller
{
    // 
    // GET: /
    public IActionResult Index()
    {
        return View("~/Views/Home/Privacy.cshtml");
    }

}