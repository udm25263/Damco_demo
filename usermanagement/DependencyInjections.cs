using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using usermanagement.Infrastructure.Persistence.Entities;

namespace usermanagement
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<UserManagementDbContext>(options => options.UseNpgsql(connectionString));
            return services;
        }
    }
}
