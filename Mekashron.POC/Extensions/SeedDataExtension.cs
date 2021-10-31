using ICUTechService;
using Mekashron.POC.Models.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mekashron.POC.Extensions
{
    public static class SeedDataExtension
    {
        public async static void AddDemoUser(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            ServiceProvider provider = serviceCollection.BuildServiceProvider();
            var appSettings = provider.GetRequiredService<IOptions<AppSettings>>().Value;

            using (var client = new ICUTechClient())
            {
                await client.RegisterNewCustomerAsync(Email: appSettings.seedUser.email,
                                                      Password: appSettings.seedUser.password,
                                                      FirstName: appSettings.seedUser.firstName,
                                                      LastName: appSettings.seedUser.lastName,
                                                      Mobile: appSettings.seedUser.mobile,
                                                      CountryID: appSettings.seedUser.countryId,
                                                      aID: appSettings.seedUser.aId,
                                                      SignupIP: appSettings.seedUser.singupIp
                );
            }
        }
    }
}
