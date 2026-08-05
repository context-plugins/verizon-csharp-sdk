using System.Text.Json.Serialization;
using Verizon.Models.AnyOf;

namespace Verizon.Models;

public record FrictionInformation
{
    /// <summary>
    /// Indicates the composition of the surface of the roadway for use in estimation of friction.
    /// </summary>
    [JsonPropertyName("roadSurfaceDescription")]
    public required DescriptionOfRoadSurface RoadSurfaceDescription { get; init; }
}
