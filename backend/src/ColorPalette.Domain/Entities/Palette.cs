using System.Text.Json.Serialization;

namespace ColorPalette.Domain.Entities;

public class Palette
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public List<Color> Colors { get; set; } = new();
    [JsonPropertyName("Created_At")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}