using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DescriptionOfRoadSurfaceAsphaltOrTar
{
    /// <summary>
    /// Indicates the surface of the roadway is asphalt or tar.
    /// </summary>
    [JsonPropertyName("asphaltOrTar")]
    public required AsphaltOrTar AsphaltOrTar { get; init; }
}
