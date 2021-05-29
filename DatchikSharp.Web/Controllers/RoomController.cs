using System.Threading.Tasks;
using DatchikiSharp.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatchikSharp.Web.Controllers
{
    public class RoomController : Controller
    {
        private readonly ScanerContext _context;

        public RoomController(ScanerContext context)
        {
            _context = context;
        }

        // GET
        public async Task<IActionResult> Index()
        {
            var models = await _context.Rooms.Include(r => r.Scaners).ToListAsync();
            return View(models);
        }
    }
}
