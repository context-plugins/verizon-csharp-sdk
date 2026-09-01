using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Bill usage request.
/// </summary>
public record BillUsageRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// Start date to search for billable usage, mm-dd-yyyy.
    /// </summary>
    [JsonPropertyName("startDate")]
    public required string StartDate { get; init; }

    /// <summary>
    /// End date to search for billable usage, mm-dd-yyyy.
    /// </summary>
    [JsonPropertyName("endDate")]
    public required string EndDate { get; init; }

    /// <summary>
    /// Request usage for single or multiple accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usageForAllAccounts")]
    public bool? UsageForAllAccounts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
