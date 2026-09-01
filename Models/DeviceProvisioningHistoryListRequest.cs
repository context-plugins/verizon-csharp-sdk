using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Request to return the provisioning history of a specified device during a specified time period.
/// </summary>
public record DeviceProvisioningHistoryListRequest
{
    /// <summary>
    /// An identifier for a single device.
    /// </summary>
    [JsonPropertyName("deviceId")]
    public required DeviceId DeviceId { get; init; }

    /// <summary>
    /// The earliest date and time for which you want provisioning data.
    /// </summary>
    [JsonPropertyName("earliest")]
    public required string Earliest { get; init; }

    /// <summary>
    /// The last date and time for which you want provisioning data.
    /// </summary>
    [JsonPropertyName("latest")]
    public required string Latest { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
