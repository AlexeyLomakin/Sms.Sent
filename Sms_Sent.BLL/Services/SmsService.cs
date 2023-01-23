using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sms.Sent.DAL.Models;
using System.Collections.Generic;

namespace Sms.Sent.BLL.Services
{

    public class SmsService
    {
        readonly SmsContext db;

        public SmsService(SmsContext context)
        {
            db = context;
        }

        public IEnumerable<SmsModel> GetAll() 
        {
            List<SmsModel> models = new List<SmsModel>();
            models.Add(new SmsModel {Id = 0, DateSend = System.DateTime.Now, RecepientPhone = 98746, SmsStatus = "send", SmsText = "sdasdasdas" });
            return  models;
        }
        public async  Task PostSms(SmsModel sms)
        {
            db.Add(sms);
            db.SmsDB.Add(sms);
            await db.SaveChangesAsync();
        }

        //[HttpPut]
        //public async Task<ActionResult<SmsModel>> Put(SmsModel sms)
        //{
        //    if (sms == null)
        //    {
        //        return BadRequest();
        //    }
        //    if (!db.SmsDB.Any(x => x.Id == sms.Id))
        //    {
        //        return NotFound();
        //    }

        //    db.Update(sms);
        //    await db.SaveChangesAsync();
        //    return Ok(sms);
        //}
    }
}
