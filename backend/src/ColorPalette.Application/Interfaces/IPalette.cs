using ColorPalette.Application.DTOs;
using ColorPalette.Domain.Entities;

namespace ColorPalette.Application.Interfaces;

public interface IPalette
{
    Task<Palette> AddAsync(PaletteDto paletteDto);
    Task<Palette> GetByIdAsync(int id);
    Task<List<Palette>> GetPalettesAsync();
}