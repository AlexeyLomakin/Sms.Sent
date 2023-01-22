using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sms.Sent.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sms.Sent.API.Controllers
{
    [ApiController]
    public class SmsController : ControllerBase
    {
        public SmsContext db;
        public SmsController(SmsContext context)
        {
            db = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SmsModel>>> Get()
        {
            return await db.SmsDB.ToListAsync();
        }

        [HttpGet]
        public async Task<ActionResult<SmsModel>> Get(int id)
        {
            SmsModel sms = await db.SmsDB.FirstOrDefaultAsync(x => x.Id == id);
            if (sms == null)
                return NotFound();
            return new ObjectResult(sms);

        }
    }
}
