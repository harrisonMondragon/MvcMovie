using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public string Index()
    {
        return "This is my default action...";
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public string Welcome(String name, int numTimes = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    }

    public string WelcomeWithID(String name, int ID= 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
}