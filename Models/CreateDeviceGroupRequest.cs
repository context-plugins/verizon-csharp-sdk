using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Create request for a new device group and optionally add devices to the group.
/// </summary>
public record CreateDeviceGroupRequest
{
    /// <summary>
    /// The Verizon billing account that the device group will belong to. An account name is usually numeric, and must include any leading zeros.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// A description for the device group.
    /// </summary>
    [JsonPropertyName("groupDescription")]
    public required string GroupDescription { get; init; }

    /// <summary>
    /// The name for the new device group. This name must be unique within the specified account.
    /// </summary>
    [JsonPropertyName("groupName")]
    public required string GroupName { get; init; }

    /// <summary>
    /// Zero or more devices to add to the device group. You can use POST /devices/actions/list to get a list of all devices in the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devicesToAdd")]
    public IReadOnlyList<DeviceId>? DevicesToAdd { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
