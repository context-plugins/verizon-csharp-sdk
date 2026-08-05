using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ManagedAccountsAddResponse
{
    /// <summary>
    /// Transaction identifier
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TxId")]
    public string? TxId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statusList")]
    public IReadOnlyList<StatusList>? StatusList { get; init; }
}
