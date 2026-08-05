using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Settings for anomaly detection.
/// </summary>
public record AnomalyDetectionSettings
{
    /// <summary>
    /// Indicates if the account name used has anomaly detection.&lt;br /&gt;Success - The account has anomaly detection.&lt;br /&gt;Failure - The account does not have anomaly detection.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// Details for sensitivity parameters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sensitivityParameter")]
    public SensitivityParameters? SensitivityParameter { get; init; }

    /// <summary>
    /// Indicates if anomaly detection is active on the account&lt;br /&gt;Active - Anomaly detection is active&lt;br /&gt;Disabled- Anomaly detection is not active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }
}
