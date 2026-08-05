using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Success response.
/// </summary>
public record IntelligenceSuccessResult
{
    /// <summary>
    /// Anomaly detection status.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }
}
