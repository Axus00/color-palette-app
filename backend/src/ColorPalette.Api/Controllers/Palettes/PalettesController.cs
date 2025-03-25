using ColorPalette.Application.Services.Palettes;
using Microsoft.AspNetCore.Mvc;

namespace ColorPalette.Api.Controllers.Palettes;

[ApiController]
[Route("/api/v1/[controller]")]
public class PalettesController(IPaletteService paletteService) : ControllerBase
{
    /// <summary>
    /// GetPalettesAsync
    /// </summary>
    /// <returns>
    /// Enpoint para obtener todas las paletas de colores
    /// </returns>
    [HttpGet]
    public async Task<IActionResult> GetPalettesAsync()
    {
        var result = await paletteService.GetAllAsync();
        return Ok(result.Data);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPaletteAsync(int id)
    {
        var result = await paletteService.GetByIdAsync(id);
        return Ok(result.Data);
    }
}