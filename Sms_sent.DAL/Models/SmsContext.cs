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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseNpgsql("Server=localhost; Port=5432; Database=SmsDb; User Id = postgres; Password = postgres; CommandTimeout = 20");
    }
}
