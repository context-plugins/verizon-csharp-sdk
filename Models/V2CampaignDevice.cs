using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// List of devices in a campaign.
/// </summary>
public record V2CampaignDevice
{
    /// <summary>
    /// Total device count.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalDevice")]
    public int? TotalDevice { get; init; }

    /// <summary>
    /// Has more report flag.
    /// </summary>
    [JsonPropertyName("hasMoreData")]
    public required bool HasMoreData { get; init; }

    /// <summary>
    /// Device identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastSeenDeviceId")]
    public string? LastSeenDeviceId { get; init; }

    /// <summary>
    /// Maximum page size.
    /// </summary>
    [JsonPropertyName("maxPageSize")]
    public required int MaxPageSize { get; init; }

    /// <summary>
    /// List of devices with id in IMEI.
    /// </summary>
    [JsonPropertyName("deviceList")]
    public required IReadOnlyList<V2DeviceStatus> DeviceList { get; init; }
}
