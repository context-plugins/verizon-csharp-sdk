using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Request to assign license.
/// </summary>
public record AssignLicenseRequest
{
    /// <summary>
    /// The name of a billing account.This parameter is required only if the UWS account used for the current API session has access to multiple accounts. An account name is usually numeric, and must include any leading zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    [StringLength(32, MinimumLength = 3)]
    public string? AccountName { get; init; }

    /// <summary>
    /// A list of 4G devices.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devices")]
    [MaxLength(100)]
    public IReadOnlyList<LicenseDeviceList>? Devices { get; init; }

    /// <summary>
    /// The Stock Keeping Unit (SKU). Valid skuNumbers for license types: “SIMSec-IoT-Lt”. (Lifetime) Once a license is assigned to a SIM, the SIM-Secure feature is enabled for the life of the SIM.“TS-BUNDLE-KTO-SIMSEC-MRC”. (Bundle) The SIM-Secure Flex license can be assigned to or removed from a SIM at any time. This SKU is bundled with other ThingSpace Services.“SIMSec-IoT”. (Flex) The SIM-Secure Flex license can be assigned to or removed from a SIM at any time. This SKU is purchased a la carte.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skuNumber")]
    [StringLength(32, MinimumLength = 3)]
    public string? SkuNumber { get; init; }
}
