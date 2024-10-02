using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SalesSystem.Repository.Implementation;
using SalesSystem.Repository.Interfaces;

namespace SalesSystem.Repository;

public static class DependencyInjection
{
    public static void RegisterRepositoryDependencies(this IServiceCollection services)
    {   
        services.AddTransient<IMeasurement, MeasurementRepository>();
        services.AddTransient<ICategory, CategoryRepository>();
    }
}
