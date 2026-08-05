using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Request for a subscription.
/// </summary>
public record SecuritySubscriptionRequest
{
    /// <summary>
    /// The name of a billing account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9]{3,32}$")]
    public string? AccountName { get; init; }

    /// <summary>
    /// The Stock Keeping Unit (SKU). Valid skuNumbers for SIM-Secure for IoT are:SIMSec-IoT-Lt”. (Lifetime) Once a license is assigned to a SIM, the SIM-Secure feature is enabled for the life of the SIM.“TS-BUNDLE-KTO-SIMSEC-MRC”. (Bundle) The SIM-Secure Flex license can be assigned to or removed from a SIM at any time. This SKU is bundled with other ThingSpace Services.*“SIMSec-IoT”. (Flex) The SIM-Secure Flex license can be assigned to or removed from a SIM at any time. This SKU is purchased a la carte.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skuNumber")]
    [StringLength(32, MinimumLength = 3)]
    public string? SkuNumber { get; init; }
}
