using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Make changes to a device group, including changing the name and description, and adding or removing devices.
/// </summary>
public record DeviceGroupUpdateRequest
{
    /// <summary>
    /// Zero or more devices to add to the device group, specified by device ID. The devices will be removed from their current device groups. You can use POST /devices/actions/list to get a list of all devices in the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devicesToAdd")]
    public IReadOnlyList<DeviceId>? DevicesToAdd { get; init; }

    /// <summary>
    /// Zero or more devices to remove from the device group, specified by device ID. The devices will be added to the default device group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devicesToRemove")]
    public IReadOnlyList<DeviceId>? DevicesToRemove { get; init; }

    /// <summary>
    /// A new description for the device group. Do not include this parameter to leave the group description unchanged.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("newGroupDescription")]
    public string? NewGroupDescription { get; init; }

    /// <summary>
    /// A new name for the device group. Do not include this parameter if you want to leave the group name unchanged.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("newGroupName")]
    public string? NewGroupName { get; init; }
}
