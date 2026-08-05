using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Device Id details.
/// </summary>
public record DeviceIdentifier
{
    /// <summary>
    /// Kind of device.
    /// </summary>
    [JsonPropertyName("kind")]
    [StringLength(6, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z]{3,6}$")]
    public required string Kind { get; init; }

    /// <summary>
    /// Device Identity number.
    /// </summary>
    [JsonPropertyName("id")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[0-9]{3,32}$")]
    public required string Id { get; init; }

    /// <summary>
    /// Device MDN number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mdn")]
    [StringLength(10, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9]{3,10}$")]
    public string? Mdn { get; init; }
}
