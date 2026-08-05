using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Get device experience score bulk request.
/// </summary>
public record GetDeviceExperienceScoreBulkRequest
{
    /// <summary>
    /// Account name.
    /// </summary>
    [JsonPropertyName("accountName")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[0-9-]{3,32}$")]
    public required string AccountName { get; init; }

    [JsonPropertyName("deviceList")]
    [MaxLength(100)]
    public required IReadOnlyList<DeviceIdentifier> DeviceList { get; init; }
}
