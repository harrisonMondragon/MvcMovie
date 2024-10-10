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
    public string Welcome(String name, int exampleNum)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {exampleNum}");
    }

    public string WelcomeWithID(String name, int ID)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
}