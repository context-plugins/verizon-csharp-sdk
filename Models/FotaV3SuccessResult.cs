using System.Text.Json.Serialization;
using Verizon.Core.Models;

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
