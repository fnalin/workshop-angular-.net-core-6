using FN.WorkShopNetCoreAngular.Data.EF;
using FN.WorkShopNetCoreAngular.Data.EF.Repositories;
using FN.WorkShopNetCoreAngular.Domain.Contracts.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FN.WorkShopNetCoreAngular.CrossCutting.IoC;

public static class Configuration
{
    public static void RegisterServices(this IServiceCollection services)
    {
        registerData(services);
    }

    private static void registerData(IServiceCollection services)
    {
        services.AddScoped<WorkShopNetCoreAngularDbContext>();

        services.AddTransient<IClienteRepository, ClienteRepository>();
    }
}