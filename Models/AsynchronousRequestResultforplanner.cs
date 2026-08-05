using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// A successful request returns the request ID (UUID) and the current status.
/// </summary>
public record AsynchronousRequestResultforplanner
{
    /// <summary>
    /// The unique ID of a request. This is a UUID value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestId")]
    public string? RequestId { get; init; }
}
