using ColorPalette.Application.DTOs;
using ColorPalette.Application.Interfaces;
using ColorPalette.Application.Shared;
using ColorPalette.Domain.Entities;
using ColorPalette.Domain.Exceptions;

namespace ColorPalette.Application.Services.Palettes;

public class PaletteService(IPalette paletteRepository) : IPaletteService
{
    public Task<ApiResponse<Palette>> CreatePaletteAsync(PaletteDto paletteDto, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<ApiResponse<Palette>> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        try
        {
            var palette = await paletteRepository.GetByIdAsync(id);
            return ApiResponse<Palette>.SuccessResponse(palette);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<ApiResponse<List<Palette>>> GetAllAsync()
    {
        try
        {
            var palettes = await paletteRepository.GetPalettesAsync();
            return ApiResponse<List<Palette>>.SuccessResponse(palettes);
        }
        catch (Exception ex)
        {
            throw new Exceptions.CreateInternalServerError(ex);
        }
    }
}