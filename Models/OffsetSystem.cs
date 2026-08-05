using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// The OffsetSystem data frame selects a sequence of node offsets described in the Lat-Long offset method.
/// </summary>
public record OffsetSystem
{
    /// <summary>
    /// The sequence of node offsets then describes a path or polygon in the Lat-Long system.
    /// </summary>
    [JsonPropertyName("offset")]
    public required Offset Offset { get; init; }
}
