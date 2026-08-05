using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// FOTA Subscription.
/// </summary>
public record FotaV2Subscription
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// Subscription models used by the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purchaseType")]
    public string? PurchaseType { get; init; }

    /// <summary>
    /// Number of monthly licenses in an MRC subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("licenseCount")]
    public int? LicenseCount { get; init; }

    /// <summary>
    /// Number of licenses currently assigned to devices.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("licenseUsedCount")]
    public int? LicenseUsedCount { get; init; }

    /// <summary>
    /// The date and time of when the subscription was last updated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; init; }
}
