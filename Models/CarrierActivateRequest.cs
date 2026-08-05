using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Request for carrier activation.
/// </summary>
public record CarrierActivateRequest
{
    /// <summary>
    /// Up to 10,000 devices for which you want to activate service, specified by device identifier.
    /// </summary>
    [JsonPropertyName("devices")]
    public required IReadOnlyList<AccountDeviceList> Devices { get; init; }

    /// <summary>
    /// The service plan code that you want to assign to all specified devices.
    /// </summary>
    [JsonPropertyName("servicePlan")]
    public required string ServicePlan { get; init; }

    /// <summary>
    /// The Zip code of the location where the line of service will primarily be used, or a Zip code that you have been told to use with these devices. For accounts that are configured for geographic numbering, this is the ZIP code from which the MDN will be derived.
    /// </summary>
    [JsonPropertyName("mdnZipCode")]
    public required string MdnZipCode { get; init; }

    /// <summary>
    /// The name of a billing account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// The private IP pool (Carrier Group Name) from which your device IP addresses will be derived.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierIpPoolName")]
    public string? CarrierIpPoolName { get; init; }

    /// <summary>
    /// The carrier that will perform the activation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierName")]
    public string? CarrierName { get; init; }

    /// <summary>
    /// A string to identify the cost center that the device is associated with.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("costCenterCode")]
    public string? CostCenterCode { get; init; }

    /// <summary>
    /// A user-defined descriptive field, limited to 50 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customFields")]
    public IReadOnlyList<CustomFields>? CustomFields { get; init; }

    /// <summary>
    /// If you specify devices by ID in the devices parameters, this is the name of a device group that the devices should be added to.If you don't specify individual devices with the devices parameter, you can provide the name of a device group to activate all devices in that group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("groupName")]
    public string? GroupName { get; init; }

    /// <summary>
    /// The ID of a “Qualified” or “Closed - Won” VPP customer lead, which is used with other values to determine MDN assignment, taxation, and compensation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("leadId")]
    public string? LeadId { get; init; }

    /// <summary>
    /// The customer name and the address of the device's primary place of use. Leave these fields empty to use the account profile address as the primary place of use. These values will be applied to all devices in the request.If the account is enabled for non-geographic MDNs and the device supports it, the primaryPlaceOfUse address will also be used to derive the MDN for the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primaryPlaceOfUse")]
    public PlaceOfUse? PrimaryPlaceOfUse { get; init; }

    /// <summary>
    /// For devices with static IP addresses on the public network, this specifies whether the devices have general access to the Internet.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("publicIpRestriction")]
    public string? PublicIpRestriction { get; init; }

    /// <summary>
    /// The Stock Keeping Unit (SKU) of a 4G device type can be used with ICCID device identifiers in lieu of an IMEI when activating 4G devices. The SkuNumber will be used with all devices in the request, so all devices must be of the same type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skuNumber")]
    public string? SkuNumber { get; init; }
}
