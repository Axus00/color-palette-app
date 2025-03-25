using ColorPalette.Application.DTOs;
using ColorPalette.Application.Services.Palettes;
using Microsoft.AspNetCore.Mvc;

namespace ColorPalette.Api.Controllers.Palettes;

[ApiController]
[Route("/api/v1/[controller]")]
public class PaletteCreateController(IPaletteService paletteService) : ControllerBase
{
    /// <summary>
    /// CreatePalettes
    /// </summary>
    /// <returns>
    /// Endpoint para crear una paleta de colores
    /// </returns>
    [HttpPost]
    public async Task<IActionResult> CreatePalletes([FromBody] PaletteDto paletteDto)
    {
        var result = await paletteService.CreatePaletteAsync(paletteDto);
        return Ok(result.Data);
    }
}