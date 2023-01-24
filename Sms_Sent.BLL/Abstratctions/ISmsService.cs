using Sms.Sent.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sms_Sent.BLL.Abstratctions
{
    public interface ISmsService
    {
        IEnumerable<SmsModel> GetAll();

        Task PostSms(SmsModel sms);
    }
}
