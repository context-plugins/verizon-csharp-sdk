using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// List of devices.
/// </summary>
public record DeviceListQueryResult
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// True if there are more devices to retrieve.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hasMoreData")]
    public bool? HasMoreData { get; init; }

    /// <summary>
    /// If hasMoreData=true, the startIndex to use for the next request. 0 if hasMoreData=false.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastSeenDeviceId")]
    public long? LastSeenDeviceId { get; init; }

    /// <summary>
    /// The list of devices in the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceList")]
    public IReadOnlyList<DeviceListQueryItem>? DeviceList { get; init; }
}
