using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// The sequence of node offsets then describes a path or polygon in the Lat-Long system.
/// </summary>
public record Offset
{
    /// <summary>
    /// The NodeListLL data structure provides the sequence of signed offset node point values for determining the latitude and longitude. Each LL point is referred to as a node point.
    /// </summary>
    [JsonPropertyName("ll")]
    public required NodeListLl Ll { get; init; }
}
