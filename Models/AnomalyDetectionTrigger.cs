using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Trigger for anomaly detection.
/// </summary>
public record AnomalyDetectionTrigger
{
    /// <summary>
    /// Trigger ID to identify the request in a callback.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerId")]
    public string? TriggerId { get; init; }
}
