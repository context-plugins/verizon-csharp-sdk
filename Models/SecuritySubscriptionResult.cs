using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Response for a subscription request.
/// </summary>
public record SecuritySubscriptionResult
{
    /// <summary>
    /// The name of a billing account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// The list of SKU numbers and counts for each license type specified in the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscriptionList")]
    [MaxLength(5)]
    public IReadOnlyList<SecuritySubscription>? SubscriptionList { get; init; }
}
