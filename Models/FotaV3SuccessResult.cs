using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Cancelation status.
/// </summary>
public record FotaV3SuccessResult
{
    /// <summary>
    /// True or false.
    /// </summary>
    [JsonPropertyName("success")]
    public required bool Success { get; init; }
}
