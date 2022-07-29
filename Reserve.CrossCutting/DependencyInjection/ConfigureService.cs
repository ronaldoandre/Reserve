using Microsoft.Extensions.DependencyInjection;
using Reserve.Service.Service;
using Reserve.Domain.Interfaces;

namespace Reserve.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService (IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IService,CovidService>();
        }
    }
}