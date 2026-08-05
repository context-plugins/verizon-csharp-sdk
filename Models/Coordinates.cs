using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Coordinates information.
/// </summary>
public record Coordinates
{
    /// <summary>
    /// Latitude value of location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("latitude")]
    [StringLength(12, MinimumLength = 3)]
    [RegularExpression("^[-+]?([0-9.]{3,12})$")]
    public string? Latitude { get; init; }

    /// <summary>
    /// Longitude value of location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("longitude")]
    [StringLength(12, MinimumLength = 3)]
    [RegularExpression("^[-+]?([0-9.]{3,12})$")]
    public string? Longitude { get; init; }
}
