using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DatchikiSharp.Core;
using DatchikiSharp.Core.Entitites;
using DatchikSharp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatchikSharp.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly ScanerContext _context;

        public AdminController(ScanerContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var model = new RoomsScanersViewModel()
            {
                Rooms = await _context.Rooms.ToListAsync(),
                Scaners = await _context.Scaners.ToListAsync()
            };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> CreateEditScaner()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateEditScaner(Scaner model)
        {
            if (ModelState.IsValid && !_context.Scaners.Any(s => s.Id == model.Id))
            {
                await _context.Scaners.AddAsync(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
        public async Task<IActionResult> CreateEditRoom()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateEditRoom(Room model)
        {
            if (ModelState.IsValid && !_context.Rooms.Any(s => s.Number == model.Number))
            {
                await _context.Rooms.AddAsync(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
