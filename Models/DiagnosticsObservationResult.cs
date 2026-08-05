using System;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// A success response containing the current status of the request.
/// </summary>
public record DiagnosticsObservationResult
{
    /// <summary>
    /// Transaction identifier.
    /// </summary>
    [JsonPropertyName("transactionID")]
    public required string TransactionId { get; init; }

    /// <summary>
    /// Status of the request.
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    /// <summary>
    /// The date and time of when this request was created.
    /// </summary>
    [JsonPropertyName("createdOn")]
    public required DateTimeOffset CreatedOn { get; init; }
}
