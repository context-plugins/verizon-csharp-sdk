using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Response to SMS messages sent by all M2M devices associated with a billing account.
/// </summary>
public record SmsmessagesQueryResult
{
    /// <summary>
    /// False for a status 200 response.True for a status 202 response, indicating that there is more data to be retrieved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hasMoreData")]
    public bool? HasMoreData { get; init; }

    /// <summary>
    /// An array of up to 100 SMS messages that were sent by devices in the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("messages")]
    public IReadOnlyList<Smsmessage>? Messages { get; init; }
}
