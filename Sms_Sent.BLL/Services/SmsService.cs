using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sms.Sent.DAL.Models;
using System.Linq;
using System.Collections.Generic;

namespace Sms.Sent.BLL.Services
{
    [ApiController]
    class SmsService : ControllerBase
    {
        readonly SmsContext db;
        public SmsService(SmsContext context)
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
