using System;
using System.Linq;
using System.Threading.Tasks;
using DatchikiSharp.Core;
using Microsoft.AspNetCore.Components;
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
        public async Task<IActionResult> Index()
        {
            var models = await _context.Rooms.Include(r => r.Scaners).ToListAsync();
            return View(models);
        }
        [Microsoft.AspNetCore.Mvc.Route("{controller}/{id}")]
        public async Task<IActionResult> Room(int id)
        {
            var model = await _context.Rooms.Include(r => r.Scaners).ThenInclude(r => r.ScanerJsonEvent)
                .FirstOrDefaultAsync(r => r.Id.Equals(id));
            return View(model);
        }
    }
}
