using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using SignalRHubTest.Data.Persistence;

namespace SignalRHubTest.Data
{
    public static class DependenciesInjection
    {
        public static IServiceCollection AddIdentity(this IServiceCollection services, IConfiguration configuration)
        {
            var Connectionstring = configuration.GetConnectionString("DefaultConnection") ?? string.Empty;

            services.AddDbContext<ApplicationDb>(options =>options => UseSqlServer(Connectionstring));
            services.AddDataBaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount =true)
                .AddEntityFrameworkStores<ApplicationDb>();
            return services;
        }

        public static IServiceCollection CustomSignalR(this IServiceCollection services)
        {
            services.AddSignalR();
            return services;
        }
    }
}
