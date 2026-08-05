using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Request to return service suspension information about one or more devices.
/// </summary>
public record DeviceSuspensionStatusRequest
{
    /// <summary>
    /// The devices that you want to include in the request, specified by device identifier. You only need to provide one identifier per device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceIds")]
    public IReadOnlyList<DeviceId>? DeviceIds { get; init; }

    /// <summary>
    /// Filter for devices without account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public DeviceFilterWithoutAccount? Filter { get; init; }

    /// <summary>
    /// The name of a billing account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }
}
