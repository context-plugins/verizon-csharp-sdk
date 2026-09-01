using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record DescriptionOfRoadSurfaceIce
{
    /// <summary>
    /// Indicates the surface of the roadway is ice.
    /// </summary>
    [JsonPropertyName("ice")]
    public required Ice Ice { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
