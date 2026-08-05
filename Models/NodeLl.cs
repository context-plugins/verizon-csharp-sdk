using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// The NodeLL data frame presents a structure to hold data for a signal node point in a lane. Each selected node has a complete lat-long representation.
/// </summary>
public record NodeLl
{
    /// <summary>
    /// The NodeOffsetPointLL data frame presents a structure to hold 64 bits sized data frames for a single node geometry path. Nodes are described in terms of latitude and longitude.
    /// </summary>
    [JsonPropertyName("delta")]
    public required NodeOffsetPointLl Delta { get; init; }
}
