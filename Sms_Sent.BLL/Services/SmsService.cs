using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sms.Sent.DAL.Models;

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
        
    }
}
