using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record DescriptionOfRoadSurfacePortlandCement
{
    /// <summary>
    /// Indicates the surface of the roadway is portland cement.
    /// </summary>
    [JsonPropertyName("portlandCement")]
    public required PortlandCement PortlandCement { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
