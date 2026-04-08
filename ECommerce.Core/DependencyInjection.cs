using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            // Register infrastructure services here
            // e.g., services.AddScoped<IEmailService, EmailService>();
            return services;
        }
    }
}
