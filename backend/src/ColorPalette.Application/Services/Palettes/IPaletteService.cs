using ColorPalette.Application.DTOs;
using ColorPalette.Application.Shared;
using ColorPalette.Domain.Entities;

namespace ColorPalette.Application.Services.Palettes;

public interface IPaletteService
{
    Task<ApiResponse<Palette>> CreatePaletteAsync(PaletteDto paletteDto, CancellationToken cancellationToken = default);
    Task<ApiResponse<Palette>> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<ApiResponse<List<Palette>>> GetAllAsync();
}