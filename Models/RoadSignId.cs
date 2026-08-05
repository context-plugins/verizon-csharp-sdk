using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// It provide a precise location of one or more roadside signs.
/// </summary>
public record RoadSignId
{
    /// <summary>
    /// Precise location of a road sign in the WGS-84 coordinate system, from which short offsets may be used to create additional data using a flat earth projection centered on this location.
    /// </summary>
    [JsonPropertyName("position")]
    public required RoadSignPosition Position { get; init; }

    /// <summary>
    /// OctetStrings are described as hexadecimal strings, where each octet is represented by two hexadecimal characters.
    /// </summary>
    [JsonPropertyName("viewAngle")]
    [RegularExpression("^[0-9A-Fa-f]{4}$")]
    public required string ViewAngle { get; init; }
}
