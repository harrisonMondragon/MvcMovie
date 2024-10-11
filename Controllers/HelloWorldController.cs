using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public IActionResult Welcome(String name, int numTimes)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["numTimes"] = numTimes; 
        return View();
    }

    public string WelcomeWithID(String name, int ID)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
}