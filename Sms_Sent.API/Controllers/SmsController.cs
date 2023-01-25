using Microsoft.AspNetCore.Mvc;
using Sms.Sent.DAL.Models;
using System.Collections.Generic;
using Sms_Sent.BLL.Abstratctions;

namespace Sms.Sent.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SmsController : Controller
    {
        private ISmsService _service;

        public SmsController (ISmsService service) 
        {
            _service = service;
        }

        [HttpGet]
        //GET запрос для получения всех СМС
        public ActionResult<IEnumerable<SmsModel>> GetAllSms()
        {
            var smss =  _service.GetAll();
            
            return Ok(smss);
        }

        [HttpPost]
        //POST запрос для добавления нового СМС
        public ActionResult<IEnumerable<SmsModel>> PostSms(SmsModel sms)
        {

            return Ok(_service.PostSms(sms));
        }

    }
}
