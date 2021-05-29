using HackatonCashBack.Bussines.Interfaces;
using HackatonCashBack.Bussines.Notifications;
using Microsoft.Extensions.DependencyInjection;

namespace HackatonCashBack.Api.Configuration
{
    public static class DependecyInjection
    {
        public static IServiceCollection ResolveDependecies(this IServiceCollection services)
        {
            services.AddScoped<INotificator, Notificator>();

            return services;
        }
    }
}
