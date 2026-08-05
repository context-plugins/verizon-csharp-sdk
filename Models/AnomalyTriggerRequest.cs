using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// The details of the UsageAnomaly trigger.
/// </summary>
public record AnomalyTriggerRequest
{
    /// <summary>
    /// The Verizon billing accounts associated with the anomaly triggers for this trigger to be active for devices in those accounts. An account name is usually numeric, and must include any leading zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountNames")]
    [StringLength(32, MinimumLength = 3)]
    public string? AccountNames { get; init; }

    /// <summary>
    /// Whether or not to include anomalies classified as 'abnormal'.&lt;br /&gt;true&lt;br /&gt;false&lt;br /&gt;Classification is set as part of ThingSpace Intelligence anomaly detection settings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("includeAbnormal")]
    public bool? IncludeAbnormal { get; init; }

    /// <summary>
    /// Whether or not to include anomalies classified as 'very abnormal'.&lt;br /&gt;true&lt;br /&gt;false&lt;br /&gt;Classification is set as part of ThingSpace Intelligence anomaly detection settings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("includeVeryAbnormal")]
    public bool? IncludeVeryAbnormal { get; init; }

    /// <summary>
    /// Whether or not to include anomalies that are directionally under the expected usage.&lt;br /&gt;true&lt;br /&gt;false.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("includeUnderExpectedUsage")]
    public bool? IncludeUnderExpectedUsage { get; init; }

    /// <summary>
    /// Whether or not to include anomalies that are directionally over the expected usage. &lt;br /&gt;true&lt;br /&gt;false.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("includeOverExpectedUsage")]
    public bool? IncludeOverExpectedUsage { get; init; }
}
