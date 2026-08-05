using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DescriptionOfRoadSurfaceRock
{
    /// <summary>
    /// Indicates the surface of the roadway is rock.
    /// </summary>
    [JsonPropertyName("rock")]
    public required Rock Rock { get; init; }
}
