using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SalesSystem.Repository.Implementation;
using SalesSystem.Repository.Interfaces;
using SalesSystem.Services.Implementation;
using SalesSystem.Services.Interfaces;

namespace SalesSystem.Services;

public static class DependencyInjection
{
    public static void RegisterServicesDependencies(this IServiceCollection services)
    {
        services.AddTransient<IMeasurementService, MeasurementService>();
        services.AddTransient<ICategoryService, CategoryService>();
    }
}