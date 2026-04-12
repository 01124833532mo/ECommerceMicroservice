using ECommerce.Core.ServiceContracts;
using ECommerce.Core.Services;
using ECommerce.Core.Validators;
using FluentValidation;
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
            services.AddValidatorsFromAssemblyContaining<LoginRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<RegisterRequestValidator>();


            return services;
        }
    }
}
