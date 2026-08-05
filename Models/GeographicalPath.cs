using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// The data frame is used to support the cross-cutting need in many V2X messages to describe arbitrary spatial areas (polygons, boundary lines, and other basic shapes) required by various message types in a small message size.
/// </summary>
public record GeographicalPath
{
    /// <summary>
    /// This data frame can describe a complex path of arbitrary size using node offset method (LL offsets).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public GeographicalPathDescription? Description { get; init; }

    /// <summary>
    /// OctetStrings are described as hexadecimal strings, where each octet is represented by two hexadecimal characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("direction")]
    [RegularExpression("^[0-9A-Fa-f]{4}$")]
    public string? Direction { get; init; }
}
