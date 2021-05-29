using Microsoft.AspNetCore.Mvc;

namespace DatchikSharp.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}