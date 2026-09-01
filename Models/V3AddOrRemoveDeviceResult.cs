using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Add or remove devices to existing upgrade information.
/// </summary>
public record V3AddOrRemoveDeviceResult
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// Campaign identifier.
    /// </summary>
    [JsonPropertyName("campaignId")]
    public required string CampaignId { get; init; }

    /// <summary>
    /// Array of devices changed.
    /// </summary>
    [JsonPropertyName("deviceList")]
    public required IReadOnlyList<V3DeviceListItem> DeviceList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
