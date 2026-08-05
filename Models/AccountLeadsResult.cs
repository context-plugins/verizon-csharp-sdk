using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Returns information for all leads associated with an account.
/// </summary>
public record AccountLeadsResult
{
    /// <summary>
    /// False if no more leads.True if there is more data to be retrieved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hasMoreData")]
    public bool? HasMoreData { get; init; }

    /// <summary>
    /// The leads associated with an account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("leads")]
    public IReadOnlyList<AccountLead>? Leads { get; init; }
}
