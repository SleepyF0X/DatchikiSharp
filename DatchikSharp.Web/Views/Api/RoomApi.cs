using System.Threading.Tasks;
using DatchikiSharp.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatchikSharp.Views.Api
{
    [Route("api/rooms")]
    public class RoomApi : Controller
    {
        private readonly ScanerContext _context;

        public RoomApi(ScanerContext context)
        {
            _context = context;
        }
        [HttpGet("get-rooms-list")]
        public async Task<IActionResult> GetListRooms()
        {
            var model = await _context.Rooms.ToListAsync();
            return Json(model);
        }
    }
}
