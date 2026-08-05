using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Requests the current PRL (Preferred Roaming List) version for 2G or 3G devices, which can help determine which devices need a PRL update. (4G and GSM devices do not have a PRL.).
/// </summary>
public record DevicePrlListRequest
{
    /// <summary>
    /// The devices for which you want the PRL version, specified by device identifier. You only need to provide one identifier per device. Do not use any of the other parameters if you specify device IDs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceIds")]
    public IReadOnlyList<DeviceId>? DeviceIds { get; init; }

    /// <summary>
    /// The name of a billing account. This parameter is only required if you are passing groupName and the UWS account used for the current API session has access to multiple billing accounts, because the same device group name can exist in multiple accounts.An account name is usually numeric, and must include any leading zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// The names and values of custom fields, if you want to only include devices that have matching custom fields.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customFields")]
    public IReadOnlyList<CustomFields>? CustomFields { get; init; }

    /// <summary>
    /// The name of a device group, if you want to only include devices in that group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("groupName")]
    public string? GroupName { get; init; }

    /// <summary>
    /// The name of a service plan, if you want to only include devices that have that service plan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("servicePlan")]
    public string? ServicePlan { get; init; }
}
