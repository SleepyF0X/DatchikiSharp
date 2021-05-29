using System.Linq;
using DatchikiSharp.Core;
using Microsoft.AspNetCore.Mvc;

namespace DatchikSharp.Controllers
{
    public class HomeController : Controller
    {
        // GET
        private readonly ScanerContext _context;
        public HomeController(ScanerContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = _context.Rooms.First();
            return View(model);
        }
    }
}
