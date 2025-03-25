using ColorPalette.Application.Services.Palettes;
using Microsoft.Extensions.DependencyInjection;

namespace ColorPalette.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IPaletteService, PaletteService>();
        return services;
    }
}