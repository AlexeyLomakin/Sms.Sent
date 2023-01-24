using Microsoft.Extensions.DependencyInjection;
using Sms.Sent.BLL.Services;
using Sms_Sent.BLL.Abstratctions;

namespace Sms.Sent.API
{
    internal static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBLLDataServices(this IServiceCollection services)
        {
            services.AddScoped<ISmsService,SmsService>();
            return services;
        }
    }
}
