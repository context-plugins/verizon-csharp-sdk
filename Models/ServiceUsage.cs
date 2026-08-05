using System.Text.Json.Serialization;

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
}
