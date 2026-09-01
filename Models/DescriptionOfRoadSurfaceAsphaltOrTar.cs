using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record DescriptionOfRoadSurfaceAsphaltOrTar
{
    /// <summary>
    /// Indicates the surface of the roadway is asphalt or tar.
    /// </summary>
    [JsonPropertyName("asphaltOrTar")]
    public required AsphaltOrTar AsphaltOrTar { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
