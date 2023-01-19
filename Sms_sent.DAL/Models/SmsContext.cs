using Microsoft.EntityFrameworkCore;

namespace Sms.Sent.DAL.Models
{
    public class SmsContext :DbContext
    {
        public DbSet<Sms> Sms { get; set; }

        public SmsContext(DbContextOptions<SmsContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
