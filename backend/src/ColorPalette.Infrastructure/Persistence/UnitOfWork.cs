using ColorPalette.Application.Interfaces;
using ColorPalette.Infrastructure.Data;

namespace ColorPalette.Infrastructure.Persistence;

public class UnitOfWork(ApplicationDbContext context) : IUnitOfWork
{
    public async Task<int> SaveChangesAsync()
    {
        return await context.SaveChangesAsync();
    }
    
    public void Dispose()
    {
        context.Dispose();
    }
}