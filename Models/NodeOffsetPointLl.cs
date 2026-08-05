using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// The NodeOffsetPointLL data frame presents a structure to hold 64 bits sized data frames for a single node geometry path. Nodes are described in terms of latitude and longitude.
/// </summary>
public record NodeOffsetPointLl
{
    /// <summary>
    /// A 64-bit node type with lat-long values expressed in standard SAE 1/10th of a microdegree.
    /// </summary>
    [JsonPropertyName("node-LatLon")]
    public required NodeLlmD64B NodeLatLon { get; init; }
}
