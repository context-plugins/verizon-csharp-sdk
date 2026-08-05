using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Contains the device identifiers and a success or failure response for each device in the request.
/// </summary>
public record AddDevicesResult
{
    /// <summary>
    /// Identifiers for the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceIds")]
    public IReadOnlyList<DeviceId>? DeviceIds { get; init; }

    /// <summary>
    /// The status message for the current device. This will be Success or Failed
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public string? Response { get; init; }
}
