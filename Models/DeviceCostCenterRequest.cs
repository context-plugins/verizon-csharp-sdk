using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Request to retrieve cost center value of a device.
/// </summary>
public record DeviceCostCenterRequest
{
    /// <summary>
    /// The name of a billing account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// The new cost center code. Valid values are any string of up to 36 alphanumeric characters, space, dash, exclamation point, and pound sign.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("costCenter")]
    public string? CostCenter { get; init; }

    /// <summary>
    /// Custom field names and values, if you want to only include devices that have matching values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customFields")]
    public IReadOnlyList<CustomFields>? CustomFields { get; init; }

    /// <summary>
    /// A list of the devices that you want to change, specified by device identifier. Do not include accountName, groupName, customFields, or servicePlan if you use this parameter.
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
    /// The customer name and the address of the device's primary place of use. These values are applied to all devices in the request.The Primary Place of Use location may affect taxation or have other legal implications. You may want to speak with legal and/or financial advisers before entering values for these fields.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primaryPlaceOfUse")]
    public object? PrimaryPlaceOfUse { get; init; }

    /// <summary>
    /// Set to true to remove the cost center code value. This flag takes precedence over a new costCenter value. If this flag is true and costCenter has a value, the cost center code is removed. Do not include this parameter, or set it to false to change the costCenter value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("removeCostCenter")]
    public bool? RemoveCostCenter { get; init; }

    /// <summary>
    /// The name of a service plan, if you want to only include devices that have that service plan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("servicePlan")]
    public string? ServicePlan { get; init; }
}
