using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// This data frame can describe a complex path of arbitrary size using node offset method (LL offsets).
/// </summary>
public record GeographicalPathDescription
{
    /// <summary>
    /// The OffsetSystem data frame selects a sequence of node offsets described in the Lat-Long offset method.
    /// </summary>
    [JsonPropertyName("path")]
    public required OffsetSystem Path { get; init; }
}
