using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DescriptionOfRoadSurfaceGrass
{
    /// <summary>
    /// Indicates the surface of the roadway is grass.
    /// </summary>
    [JsonPropertyName("grass")]
    public required Grass Grass { get; init; }
}
