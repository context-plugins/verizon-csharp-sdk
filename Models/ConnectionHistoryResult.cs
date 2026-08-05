using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Response containing the connection history. It is a list of Network Connection Events for a device.
/// </summary>
public record ConnectionHistoryResult
{
    /// <summary>
    /// Device connection events, sorted by the occurredAt timestamp, oldest first.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("connectionHistory")]
    public IReadOnlyList<ConnectionEvent>? ConnectionHistory { get; init; }

    /// <summary>
    /// False for a status 200 response.True for a status 202 response, indicating that there is more data to be retrieved. Send another request, adjusting the earliest value in the request based on the occuredAt value for the last device in the current response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hasMoreData")]
    public bool? HasMoreData { get; init; }
}
