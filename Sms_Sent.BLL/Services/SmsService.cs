using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sms.Sent.DAL.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;

namespace Sms.Sent.BLL.Services
{
    class SmsService : ControllerBase
    {
        readonly SmsContext db;
        public SmsService(SmsContext context)
        {
            db = context;
        }
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<SmsModel>>> Get()
        //{
        //    return await db.SmsDB.ToListAsync();
        //}

        //[HttpGet]
        //public async Task<ActionResult<SmsModel>> Get(int id)
        //{
        //    SmsModel sms = await db.SmsDB.FirstOrDefaultAsync(x => x.Id == id);
        //    if (sms == null)
        //        return NotFound();
        //    return new ObjectResult(sms);
        //}
        [HttpPut]
        public async Task<ActionResult<SmsModel>> Put(SmsModel sms)
        {
            if (sms == null)
            {
                return BadRequest();
            }
            if (!db.SmsDB.Any(x => x.Id == sms.Id))
            {
                return NotFound();
            }

            db.Update(sms);
            await db.SaveChangesAsync();
            return Ok(sms);
        }
    }
}
