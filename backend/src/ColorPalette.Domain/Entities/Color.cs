namespace ColorPalette.Domain.Entities;

public class Color
{
    public int Id { get; set; }
    public required string Hex { get; set; }
    public required string Name { get; set; }
    public int PaletteId { get; set; }
    public Palette Palettes { get; set; }
}