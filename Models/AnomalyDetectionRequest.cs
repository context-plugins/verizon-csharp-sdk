using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Anomaly detection request.
/// </summary>
public record AnomalyDetectionRequest
{
    /// <summary>
    /// The name of a billing account. An account name is usually numeric, and must include any leading zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    [StringLength(32, MinimumLength = 3)]
    public string? AccountName { get; init; }

    /// <summary>
    /// The type of request being made. anomaly is the request to activate anomaly detection.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestType")]
    public string? RequestType { get; init; }

    /// <summary>
    /// Details for sensitivity parameters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sensitivityParameter")]
    public SensitivityParameters? SensitivityParameter { get; init; }
}
