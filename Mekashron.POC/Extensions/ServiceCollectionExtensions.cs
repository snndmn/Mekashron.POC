using ICUTechService;
using Mekashron.POC.Abstract;
using Mekashron.POC.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Mekashron.POC.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCommonInfrastructure(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddScoped<IAuthService, AuthService>();
        }

    }
}
