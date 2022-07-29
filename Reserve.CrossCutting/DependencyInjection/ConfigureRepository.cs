using Microsoft.Extensions.DependencyInjection;
using Reserve.Data.Repository;
using Reserve.Domain.Interfaces;

namespace Reserve.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository (IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRepository,Repository>();
        }
    }
}