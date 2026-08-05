using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Request to add the devices.
/// </summary>
public record AddDevicesRequest
{
    /// <summary>
    /// The initial service state for the devices. The only valid state is “Pre-active.”
    /// </summary>
    [JsonPropertyName("state")]
    public required string State { get; init; }

    /// <summary>
    /// The devices that you want to add.
    /// </summary>
    [JsonPropertyName("devicesToAdd")]
    public required IReadOnlyList<AccountDeviceList> DevicesToAdd { get; init; }

    /// <summary>
    /// The billing account to which the devices are added.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// The names and values for any custom fields that you want set for the devices as they are added to the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customFields")]
    public IReadOnlyList<CustomFields>? CustomFields { get; init; }

    /// <summary>
    /// The name of a device group to add the devices to. They are added to the default device group if you don't include this parameter.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("groupName")]
    public string? GroupName { get; init; }

    /// <summary>
    /// The Stock Keeping Unit (SKU) number of a 4G device type with an embedded SIM.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skuNumber")]
    public string? SkuNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smsrOid")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9]{3,32}$")]
    public string? SmsrOid { get; init; }
}
