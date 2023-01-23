using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sms.Sent.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sms.Sent.BLL.Services;
using System.Linq;

namespace Sms.Sent.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SmsController : Controller
    {
        private SmsService _service;

        public SmsController (SmsService service) 
        {
            _service = service;
        }

        [HttpGet]
        public  ActionResult<IEnumerable<SmsModel>> GetAllSms()
        {
            var smss =  _service.GetAll();
            
            return Ok(smss);
        }

        //[HttpPost]
        //public Task<ActionResult<SmsModel>>

    }
}
