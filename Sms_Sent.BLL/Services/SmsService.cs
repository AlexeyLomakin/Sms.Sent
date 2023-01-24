using System.Threading.Tasks;
using Sms.Sent.DAL.Models;
using System.Collections.Generic;
using System.Linq;
using Sms_Sent.BLL.Abstratctions;
using Sms_Sent.BLL.Helpers;

namespace Sms.Sent.BLL.Services
{
    public class SmsService : ISmsService
    {
        readonly SmsContext db;
        Dictionary<int, string> status = new Dictionary<int, string>();

        public SmsService(SmsContext context)
        {
            db = context;
            status = new Dictionary<int, string>()
            {
                { 1, "Send"},
                { 2, "Dilevered"},
                { 3, "ErrorSent"}
            };
        }

        public IEnumerable<SmsModel> GetAll() 
        {
            List<SmsModel> models = new List<SmsModel>();
            return  db.SmsDB.ToList();
        }

        public async  Task PostSms(SmsModel sms)
        {
            int randomStatus = Randomizer.GetRandomStatus();

            List<SmsModel> models = new List<SmsModel>();
            sms.DateSend = System.DateTime.UtcNow;
            sms.SmsStatus = status[randomStatus];
            db.SmsDB.Add(sms);
            await db.SaveChangesAsync();           
        }
    }
}
