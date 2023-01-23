using Microsoft.EntityFrameworkCore;

namespace Sms.Sent.DAL.Models
{
    public class SmsContext :DbContext
    {
        public DbSet<SmsModel> SmsDB { get; set; }

        public SmsContext(DbContextOptions<SmsContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
