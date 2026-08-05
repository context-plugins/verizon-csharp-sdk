using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// The transaction ID of the request that you want to cancel, from the POST /devicelocations synchronus response.
/// </summary>
public record TransactionId
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("txid")]
    public string? Txid { get; init; }
}
