using Microsoft.Extensions.DependencyInjection;
using Onion.Repository.DB;
using Onion.Repository.Interface;
using Onion.Repository.Repository;
using Onion.Service.Interface;
using Onion.Service.Service;
using System;
using System.Collections.Generic;
using System.Text;

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
