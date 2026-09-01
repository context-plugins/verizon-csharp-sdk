using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// List of device information for an account.
/// </summary>
public record V2AccountDeviceList
{
    /// <summary>
    /// Account name.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// Has more device flag?
    /// </summary>
    [JsonPropertyName("hasMoreData")]
    public required bool HasMoreData { get; init; }

    /// <summary>
    /// Last seen device identifier.
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
    /// Account device list.
    /// </summary>
    [JsonPropertyName("deviceList")]
    public required IReadOnlyList<V2AccountDevice> DeviceList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
