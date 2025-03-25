using ColorPalette.Application.Interfaces;
using ColorPalette.Infrastructure.Data;
using ColorPalette.Infrastructure.Persistence;
using ColorPalette.Infrastructure.Persistence.Palettes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ColorPalette.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IPalette, PaletteRepository>();
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseMySql(
                configuration.GetConnectionString("DefaultConnection"),
                Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql"));
        });
        return services;
    }
}