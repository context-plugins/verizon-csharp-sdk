using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DescriptionOfRoadSurfaceIce
{
    /// <summary>
    /// Indicates the surface of the roadway is ice.
    /// </summary>
    [JsonPropertyName("ice")]
    public required Ice Ice { get; init; }
}
