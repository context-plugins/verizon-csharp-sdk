using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Response to a successful request.
/// </summary>
public record FotaV2SuccessResult
{
    [JsonPropertyName("success")]
    public required bool Success { get; init; }
}
