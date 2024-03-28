using Microsoft.Extensions.DependencyInjection;

namespace Wasm.Offcanvas;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddWasmOffcanvas(this IServiceCollection services)
    {
        services.AddScoped<IOffcanvasManager, OffcanvasManager>();
        return services;
    }
}