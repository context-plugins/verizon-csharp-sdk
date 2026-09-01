using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Request to delete a device request.
/// </summary>
public record DeleteDevicesRequest
{
    /// <summary>
    /// A list of up to 100 devices that you want to delete, specified by device identifier. You only need to provide one identifier per device.
    /// </summary>
    [JsonPropertyName("devicesToDelete")]
    public required IReadOnlyList<AccountDeviceList> DevicesToDelete { get; init; }

    /// <summary>
    /// The Verizon billing account that the device group belongs to. An account name is usually numeric, and must include any leading zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
