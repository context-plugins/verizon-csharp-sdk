using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DescriptionOfRoadSurfacePortlandCement
{
    /// <summary>
    /// Indicates the surface of the roadway is portland cement.
    /// </summary>
    [JsonPropertyName("portlandCement")]
    public required PortlandCement PortlandCement { get; init; }
}
