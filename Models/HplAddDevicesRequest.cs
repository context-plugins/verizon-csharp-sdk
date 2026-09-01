using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Request to add the devices.
/// </summary>
public record HplAddDevicesRequest
{
    /// <summary>
    /// The initial service state for the devices. The only valid state is "Preactive."
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public string? State { get; init; }

    /// <summary>
    /// The devices that you want to add.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devicesToAdd")]
    public IReadOnlyList<HplAccountDeviceList>? DevicesToAdd { get; init; }

    /// <summary>
    /// The numeric name of the account and must include leading zeroes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// The names and values for any custom fields that you want set for the devices as they are added to the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customFields")]
    public IReadOnlyList<HplCustomFields>? CustomFields { get; init; }

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

    /// <summary>
    /// The Subscription Manager Secure Router Object ID, used for remote SIM provisioning. SMSR securely routes the download and management of eSIM profiles.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smsrOid")]
    public string? SmsrOid { get; init; }

    /// <summary>
    /// numberOfVirtualImei.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberOfVirtualImei")]
    public int? NumberOfVirtualImei { get; init; }

    /// <summary>
    /// uploadType.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uploadType")]
    public string? UploadType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
