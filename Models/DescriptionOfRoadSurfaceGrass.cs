using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record DescriptionOfRoadSurfaceGrass
{
    /// <summary>
    /// Indicates the surface of the roadway is grass.
    /// </summary>
    [JsonPropertyName("grass")]
    public required Grass Grass { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
