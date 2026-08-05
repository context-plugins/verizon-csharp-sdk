using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Changes the provisioning state of one or more devices to a specified customer-defined service and state.
/// </summary>
public record GoToStateRequest
{
    /// <summary>
    /// The name of a customer-defined service to push the devices to.
    /// </summary>
    [JsonPropertyName("serviceName")]
    public required string ServiceName { get; init; }

    /// <summary>
    /// The name of a customer-defined stage state to push the devices to.
    /// </summary>
    [JsonPropertyName("stateName")]
    public required string StateName { get; init; }

    /// <summary>
    /// The service plan code that you want to assign to all specified devices in the new state.
    /// </summary>
    [JsonPropertyName("servicePlan")]
    public required string ServicePlan { get; init; }

    /// <summary>
    /// The Zip code of the location where the line of service will primarily be used, or a Zip code that you have been told to use with these devices. For accounts that are configured for geographic numbering, this is the ZIP code from which the MDN will be derived.
    /// </summary>
    [JsonPropertyName("mdnZipCode")]
    public required string MdnZipCode { get; init; }

    /// <summary>
    /// Up to 10,000 devices that you want to push to a different state, specified by device identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devices")]
    public IReadOnlyList<AccountDeviceList>? Devices { get; init; }

    /// <summary>
    /// Specify the kind of the device identifier, the type of match, and the string that you want to match.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public DeviceFilter? Filter { get; init; }

    /// <summary>
    /// The pool from which your device IP addresses will be derived if the service or state change requires new IP addresses.If you do not include this element, the default pool will be used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierIpPoolName")]
    public string? CarrierIpPoolName { get; init; }

    /// <summary>
    /// For devices with static IP addresses on the public network, this specifies whether the devices have general access to the Internet. Valid values are “restricted” or “unrestricted”.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("publicIpRestriction")]
    public string? PublicIpRestriction { get; init; }

    /// <summary>
    /// The Stock Keeping Unit (SKU) number of a 4G device type with an embedded SIM. Can be used with ICCID or EID device identifiers in lieu of an IMEI when activating 4G devices. The SkuNumber will be used with all devices in the request, so all devices must be of the same type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skuNumber")]
    public string? SkuNumber { get; init; }

    /// <summary>
    /// The names and values of any custom fields that you want to set for the devices.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customFields")]
    public IReadOnlyList<CustomFields>? CustomFields { get; init; }

    /// <summary>
    /// This is an array that associates an IP address with a device identifier. This variable is only relevant for Business Internet/Fixed Wireless Access
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devicesWithServiceAddress")]
    public IReadOnlyList<object>? DevicesWithServiceAddress { get; init; }

    /// <summary>
    /// The IP address of the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; init; }

    /// <summary>
    /// The name of a device group that the devices should be added to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("groupName")]
    public string? GroupName { get; init; }

    /// <summary>
    /// The customer name and the address of the device's primary place of use. Leave these fields empty to use the account profile address as the primary place of use. These values will be applied to all devices in the request.If the account is enabled for non-geographic MDNs and the device supports it, the primaryPlaceOfUse address will also be used to derive the MDN for the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primaryPlaceOfUse")]
    public PlaceOfUse? PrimaryPlaceOfUse { get; init; }
}
