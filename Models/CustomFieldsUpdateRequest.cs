using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Request to assign or change custom field values for one or more devices.
/// </summary>
public record CustomFieldsUpdateRequest
{
    /// <summary>
    /// The name of a billing account.This parameter is only required if the UWS account used for the current API session has access to multiple billing accounts.An account name is usually numeric, and must include any leading zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// Custom field names and values, if you want to only include devices that have matching values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customFields")]
    public IReadOnlyList<CustomFields>? CustomFields { get; init; }

    /// <summary>
    /// The names and new values of any custom fields that you want to change.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customFieldsToUpdate")]
    public IReadOnlyList<CustomFields>? CustomFieldsToUpdate { get; init; }

    /// <summary>
    /// The devices that you want to change.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devices")]
    public IReadOnlyList<AccountDeviceList>? Devices { get; init; }

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
