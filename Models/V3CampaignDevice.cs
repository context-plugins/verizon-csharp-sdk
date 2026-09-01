using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Campaign history.
/// </summary>
public record V3CampaignDevice
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
    public required IReadOnlyList<V3DeviceStatus> DeviceList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
