using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Request to return the daily network data usage of a single device during a specified time period.
/// </summary>
public record DeviceUsageListRequest
{
    /// <summary>
    /// The earliest date for which you want usage data.
    /// </summary>
    [JsonPropertyName("earliest")]
    public required string Earliest { get; init; }

    /// <summary>
    /// The last date for which you want usage data.
    /// </summary>
    [JsonPropertyName("latest")]
    public required string Latest { get; init; }

    /// <summary>
    /// An identifier for a single device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceId")]
    public DeviceId? DeviceId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("label")]
    public Label? Label { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
