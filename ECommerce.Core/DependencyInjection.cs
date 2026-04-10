using ECommerce.Core.ServiceContracts;
using ECommerce.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            // Register infrastructure services here
            // e.g., services.AddScoped<IEmailService, EmailService>();

            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}
