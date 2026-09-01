using System;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Status of the diagnostic services subscription.
/// </summary>
public record DiagnosticsSubscription
{
    /// <summary>
    /// Account identifier in "##########-#####". An account name is usually numeric, and must include any leading zeros.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// The date and time of when the subscription was created.
    /// </summary>
    [JsonPropertyName("createdOn")]
    public required DateTimeOffset CreatedOn { get; init; }

    /// <summary>
    /// The date and time of when the subscription was last updated.
    /// </summary>
    [JsonPropertyName("lastUpdated")]
    public required DateTimeOffset LastUpdated { get; init; }

    /// <summary>
    /// Number of licenses currently assigned to devices.
    /// </summary>
    [JsonPropertyName("totalAllowed")]
    public required int TotalAllowed { get; init; }

    /// <summary>
    /// Number of licenses currently used by the devices.
    /// </summary>
    [JsonPropertyName("totalUsed")]
    public required int TotalUsed { get; init; }

    /// <summary>
    /// Name of the SKU for the account.
    /// </summary>
    [JsonPropertyName("skuName")]
    public required string SkuName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
