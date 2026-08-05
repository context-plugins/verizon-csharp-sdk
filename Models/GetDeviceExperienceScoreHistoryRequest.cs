using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Get device experience score history.
/// </summary>
public record GetDeviceExperienceScoreHistoryRequest
{
    /// <summary>
    /// Account name.
    /// </summary>
    [JsonPropertyName("accountName")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[0-9-]{3,32}$")]
    public required string AccountName { get; init; }

    /// <summary>
    /// Device Id details.
    /// </summary>
    [JsonPropertyName("deviceId")]
    public required DeviceIdentifier DeviceId { get; init; }
}
