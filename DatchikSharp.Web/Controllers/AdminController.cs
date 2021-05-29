using Microsoft.AspNetCore.Mvc;

namespace DatchikSharp.Web.Controllers
{
    public class AdminController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}
