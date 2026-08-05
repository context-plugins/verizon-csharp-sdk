using System.Text.Json.Serialization;
using Verizon.Models.AnyOf;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record FeatureItem
{
    [JsonPropertyName("type")]
    public required Type1 Type { get; init; }

    [JsonPropertyName("geometry")]
    public required Geometry Geometry { get; init; }

    /// <summary>
    /// Properties object for a GeoJSON Feature (no additional properties allowed).
    /// </summary>
    [JsonPropertyName("properties")]
    public required object Properties { get; init; }
}
