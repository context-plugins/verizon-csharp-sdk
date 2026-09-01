using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record DescriptionOfRoadSurfaceRock
{
    /// <summary>
    /// Indicates the surface of the roadway is rock.
    /// </summary>
    [JsonPropertyName("rock")]
    public required Rock Rock { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
