using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record DescriptionOfRoadSurfaceGravel
{
    /// <summary>
    /// Indicates the surface of the roadway is gravel.
    /// </summary>
    [JsonPropertyName("gravel")]
    public required Gravel Gravel { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
