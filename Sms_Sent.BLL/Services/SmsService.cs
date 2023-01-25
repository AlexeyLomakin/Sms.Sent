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

        //Метод получения всех смс
        public IEnumerable<SmsModel> GetAll() 
        {
            return  db.SmsDB.ToList();
        }


        //Добалвение нового СМС
        public async  Task PostSms(SmsModel sms)
        {
            int randomStatus = Randomizer.GetRandomStatus();

            sms.DateSend = System.DateTime.UtcNow;
            sms.SmsStatus = status[randomStatus];
            db.SmsDB.Add(sms);
            await db.SaveChangesAsync();

        }
    }
}
