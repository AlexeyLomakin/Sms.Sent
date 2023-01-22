using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Sms.Sent.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using Microsoft.Extensions.Configuration;

namespace Sms.Sent.API
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //использование контроллеров без представлений
            services.AddControllers();
            services.AddDbContext<SmsContext>(options =>
            options.UseNpgsql(_configuration.GetConnectionString("DefaultConnection")));

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
                endpoints.MapControllers(); //Подключаем маршрутизацию на контроллеры
            });
        }
    }
}
