using ECommerce.Core.RepositoriesContracts;
using ECommerce.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            // Register infrastructure services here
            // e.g., services.AddScoped<IEmailService, EmailService>();

            services.AddSingleton<IUserRepository, UserRepository>();
            return services;
        }
    }
}
