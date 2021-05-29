using System.Threading.Tasks;
using DatchikiSharp.Core;
using DatchikiSharp.Core.Events;
using Microsoft.AspNetCore.Mvc;

namespace DatchikSharp.Web.Controllers.Api
{
    [ApiController]
    [Route("api/events")]
    public class EventApi : Controller
    {
        private readonly ScanerContext _context;

        public EventApi(ScanerContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromBody]ScanerJsonEvent scanerEvent)
        {
            await _context.ScanerEvents.AddAsync(scanerEvent);
            (await _context.Scaners.FindAsync(scanerEvent.ScanerId)).Status = scanerEvent.Status;
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
