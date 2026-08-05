using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// The body contains the the account name and list of devices that you want to locate, plus other options.
/// </summary>
public record LocationRequest
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// Device list.
    /// </summary>
    [JsonPropertyName("deviceList")]
    public required IReadOnlyList<DeviceInfo> DeviceList { get; init; }

    /// <summary>
    /// Accurary, currently only 0-coarse supported.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accuracyMode")]
    public AccuracyMode? AccuracyMode { get; init; }

    /// <summary>
    /// Location cache mode.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cacheMode")]
    public CacheMode? CacheMode { get; init; }
}
