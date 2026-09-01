using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record DescriptionOfRoadSurfaceCinders
{
    /// <summary>
    /// Indicates the surface of the roadway is cinders.
    /// </summary>
    [JsonPropertyName("cinders")]
    public required Cinders Cinders { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
