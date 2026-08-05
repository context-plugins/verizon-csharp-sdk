using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Success response.
/// </summary>
public record SecuritySuccessResult
{
    /// <summary>
    /// A unique string that associates the request with the results that are sent via a callback message.The ThingSpace Platform sends a separate callback message for each device that matches the request criteria, indicating whether the operation succeeded for that device and containing any requested information. All callback messages will have the same requestId.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestId")]
    public string? RequestId { get; init; }
}
