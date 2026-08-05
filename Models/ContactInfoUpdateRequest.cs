using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Request to update contact information.
/// </summary>
public record ContactInfoUpdateRequest
{
    /// <summary>
    /// The customer name and the address of the device's primary place of use. Leave these fields empty to use the account profile address as the primary place of use. These values will be applied to all devices in the request.If the account is enabled for non-geographic MDNs and the device supports it, the primaryPlaceOfUse address will also be used to derive the MDN for the device.
    /// </summary>
    [JsonPropertyName("primaryPlaceOfUse")]
    public required PlaceOfUse PrimaryPlaceOfUse { get; init; }

    /// <summary>
    /// The name of the billing account that the devices belong to. An account name is usually numeric, and must include any leading zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// A list of the devices that you want to change, specified by device identifier. You only need to provide one identifier per device. Do not include accountName, groupName, customFields, or servicePlan if you use this parameter.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devices")]
    public IReadOnlyList<AccountDeviceList>? Devices { get; init; }
}
