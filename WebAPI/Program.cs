using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Entities.Model;
using Database;

namespace WebAPI
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            /*Entities.Model.IUserService userData = new Database.UserAccess();
            User newUser = new User {
                    City = "Aarhus",
                    Domain = "via.dk",
                    Password = "123456",
                    Role = "",
                    BirthYear = 2000,
                    SecurityLevel = 4,
                    UserName = "Admin"
                };
            await userData.addUser(newUser);
            //Console.WriteLine(await adultData.GetAdults());*/
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
