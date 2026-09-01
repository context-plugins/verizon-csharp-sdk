using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record DescriptionOfRoadSurfaceSnow
{
    /// <summary>
    /// Indicates the surface of the roadway is snow.
    /// </summary>
    [JsonPropertyName("snow")]
    public required Snow Snow { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
