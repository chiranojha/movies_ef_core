using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
       
            public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTImes = 1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTImes;

            return View();
        }

        public void DoesNothing()
        {
            //does nothing
        }
    }
}