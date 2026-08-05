using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// error response structure
/// </summary>
public record MdmErrorResponse
{
    /// <summary>
    /// The short summary of the error
    /// </summary>
    [JsonPropertyName("error")]
    [MaxLength(1024)]
    [RegularExpression("^[a-zA-Z0-9_-]+$")]
    public required string Error { get; init; }

    /// <summary>
    /// The detailed description of the error
    /// </summary>
    [JsonPropertyName("description")]
    [MaxLength(4096)]
    [RegularExpression("^[a-zA-Z0-9_-]+$")]
    public required string Description { get; init; }

    /// <summary>
    /// The unique identifier of the request for tracing
    /// </summary>
    [JsonPropertyName("uuid")]
    public required Guid Uuid { get; init; }

    /// <summary>
    /// The timestamp of when the error occurred
    /// </summary>
    [JsonPropertyName("timestamp")]
    public required DateTimeOffset Timestamp { get; init; }
}
