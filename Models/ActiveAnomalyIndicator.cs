using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Whether the anomaly detection is active or not.
/// </summary>
public record ActiveAnomalyIndicator
{
    /// <summary>
    /// Indicates anomaly detection is active&lt;br /&gt;True - Anomaly detection is active.&lt;br /&gt;False - Anomaly detection is not active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }
}
