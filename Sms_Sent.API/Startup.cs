using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Sms.Sent.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

namespace Sms.Sent.API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            string conn = "Server=(localdb)//npglocaldb;Database=smsstore;Trusted_Connection=True";
            //устанавливем контекст данных
            services.AddDbContext<SmsContext>(options => options.UseNpgsql(conn));
            //использование контроллеров без представлений
            services.AddControllers();

            services.AddMvc()
                .AddXmlSerializerFormatters()
                .AddMvcOptions(opts =>
                {
                    opts.FormatterMappings.SetMediaTypeMappingForFormat("xml", new MediaTypeHeaderValue("application/xml"));
                });

        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); //ѕодключаем маршрутизацию на контроллеры
            });
        }
    }
}
