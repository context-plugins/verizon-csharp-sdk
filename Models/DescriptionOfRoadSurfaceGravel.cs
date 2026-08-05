using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DescriptionOfRoadSurfaceGravel
{
    /// <summary>
    /// Indicates the surface of the roadway is gravel.
    /// </summary>
    [JsonPropertyName("gravel")]
    public required Gravel Gravel { get; init; }
}
