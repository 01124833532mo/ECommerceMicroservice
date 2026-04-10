using ECommerce.Core.RepositoriesContracts;
using ECommerce.Infrastructure.DbContext;
using ECommerce.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            // Register infrastructure services here
            // e.g., services.AddScoped<IEmailService, EmailService>();
            services.AddTransient<DapperDbContext>();

            services.AddSingleton<IUserRepository, UserRepository>();
            return services;
        }
    }
}
