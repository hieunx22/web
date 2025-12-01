using Microsoft.AspNetCore.Mvc;

namespace lap2.Controllers
{
    public class HelloWorldController : Controller
    {          
       // public IActionResult Index()
       // {
       //     return View();
        //}
        //GET:/HelloWorld/
        public string Index()

        {
            return "this is may default action...";
        }
        //GET:/HelloWorld/Welcome/
        public string Welcome()
        {
            return " this is the Welcome action method...";
        }
    }
}
