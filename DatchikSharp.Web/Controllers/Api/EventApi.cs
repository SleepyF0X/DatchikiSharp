using System;
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
        public async Task<IActionResult> Index([FromBody] ScanerJsonEvent scanerEvenst)
        {
            var scanerEvent = new ScanerJsonEvent()
            {
               
                ScanerId= scanerEvenst.ScanerId,
                Status= scanerEvenst.Status,
                DateTime=DateTime.Now
            };
            await _context.ScanerEvents.AddAsync(scanerEvent);
            (await _context.Scaners.FindAsync(scanerEvent.ScanerId)).Activity = scanerEvent.Status;
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
