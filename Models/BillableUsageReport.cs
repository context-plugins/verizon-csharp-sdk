using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Bill usage report.
/// </summary>
public record BillableUsageReport
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// The usage is for a single or multiple accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usageForAllAccounts")]
    public bool? UsageForAllAccounts { get; init; }

    /// <summary>
    /// SKU Name of the service subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skuName")]
    public string? SkuName { get; init; }

    /// <summary>
    /// The number of location requests included with the subscription type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionsAllowed")]
    public string? TransactionsAllowed { get; init; }

    /// <summary>
    /// The total number of billable device location requests during the reporting period from all included accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalTransactionCount")]
    public string? TotalTransactionCount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PrimaryAccount")]
    public ServiceUsage? PrimaryAccount { get; init; }

    /// <summary>
    /// Zero or more managed accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ManagedAccounts")]
    public IReadOnlyList<ServiceUsage>? ManagedAccounts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
