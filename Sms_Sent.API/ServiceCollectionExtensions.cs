using Microsoft.Extensions.DependencyInjection;
using Sms.Sent.BLL.Services;

namespace Sms.Sent.API
{
    internal static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBLLDataServices(this IServiceCollection services)
        {
            services.AddScoped<SmsService>();
            return services;
        }
    }
}
