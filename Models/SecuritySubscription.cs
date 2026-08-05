using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// Subscription of the device.
/// </summary>
public record SecuritySubscription
{
    /// <summary>
    /// Attributes of the subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extendedAttributes")]
    [MaxLength(5)]
    public IReadOnlyList<ExtendedAttributes>? ExtendedAttributes { get; init; }

    /// <summary>
    /// The total number of licenses for this license type that are assigned to device SIMs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("licenseAssigned")]
    [Minimum(0)]
    [Maximum(10)]
    public int? LicenseAssigned { get; init; }

    /// <summary>
    /// The total number of licenses for this license type that are available to assign to device SIMs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("licenseAvailable")]
    [Minimum(0)]
    [Maximum(10)]
    public int? LicenseAvailable { get; init; }

    /// <summary>
    /// The total number of licenses purchased for the license type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("licensePurchased")]
    [Minimum(0)]
    [Maximum(10)]
    public int? LicensePurchased { get; init; }

    /// <summary>
    /// The license type associated with the skuNumber.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; init; }

    /// <summary>
    /// The skuNumber that identifies the license type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skuNumber")]
    public string? SkuNumber { get; init; }
}
