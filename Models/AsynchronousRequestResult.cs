using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// A successful request returns the request ID and the current status.
/// </summary>
public record AsynchronousRequestResult
{
    /// <summary>
    /// The unique ID of the asynchronous request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestId")]
    public string? RequestId { get; init; }

    /// <summary>
    /// The current status of the callback response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public RequestStatus? Status { get; init; }
}
