using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Onion.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
//#1.  Install-Package Microsoft.EntityFrameworkCore.SqlServer
//#2.  Install-Package Microsoft.EntityFrameworkCore.Tools
//#3   Install-Package Microsoft.EntityFrameworkCore.Design 
//#4.  Scaffold-DbContext "Server= DESKTOP-1TP3BJN;Database=OnionDB;user id= sa;password= 123456;Trusted_Connection=True;MultipleActiveResultSets=true" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models 

    
 