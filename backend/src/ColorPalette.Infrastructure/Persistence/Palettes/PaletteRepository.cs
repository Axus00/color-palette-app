using AutoMapper;
using ColorPalette.Application.DTOs;
using ColorPalette.Application.Interfaces;
using ColorPalette.Domain.Entities;
using ColorPalette.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ColorPalette.Infrastructure.Persistence.Palettes;

public class PaletteRepository(ApplicationDbContext context, IMapper mapper, IUnitOfWork unitOfWork) : IPalette
{
    public async Task<Palette> AddAsync(PaletteDto paletteDto)
    {
        var mapping = mapper.Map<Palette>(paletteDto);
        context.Palettes.Add(mapping);
        await unitOfWork.SaveChangesAsync();
        return mapping;
    }   

    public async Task<Palette> GetByIdAsync(int id)
    {
        var palette = await context.Palettes.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        return palette!;
    }

    public async Task<List<Palette>> GetPalettesAsync()
    {
        return await context.Palettes.AsNoTracking().ToListAsync();
    }
}