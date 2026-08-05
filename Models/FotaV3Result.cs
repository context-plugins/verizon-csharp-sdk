using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Error response.
/// </summary>
public record FotaV3Result
{
    /// <summary>
    /// Error code string.
    /// </summary>
    [JsonPropertyName("errorCode")]
    public required string ErrorCode { get; init; }

    /// <summary>
    /// Error message string.
    /// </summary>
    [JsonPropertyName("errorMessage")]
    public required string ErrorMessage { get; init; }
}
