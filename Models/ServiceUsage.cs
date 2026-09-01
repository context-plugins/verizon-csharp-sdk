using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record ServiceUsage
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// Total requests for the account during the reporting period.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionsCount")]
    public string? TransactionsCount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
