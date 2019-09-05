using Microsoft.Extensions.DependencyInjection;
using Onion.Repository.DB;
using Onion.Repository;
using Onion.Service;

namespace Onion.Ioc
{
    public static class IocContainer
    {
        public static void ConfigureIOC(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserService, UserService>();
            services.AddDbContext<OnionDBContext>();
        } 
    }
}
