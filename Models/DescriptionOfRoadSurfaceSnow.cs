using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DescriptionOfRoadSurfaceSnow
{
    /// <summary>
    /// Indicates the surface of the roadway is snow.
    /// </summary>
    [JsonPropertyName("snow")]
    public required Snow Snow { get; init; }
}
