using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record DeviceLocationSubscription
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// Location service license type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locType")]
    public string? LocType { get; init; }

    /// <summary>
    /// The number of billable location requests allowed per billing cycle.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxAllowance")]
    public string? MaxAllowance { get; init; }

    /// <summary>
    /// Location service purchase time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purchaseTime")]
    public string? PurchaseTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
