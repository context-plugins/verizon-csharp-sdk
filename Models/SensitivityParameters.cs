using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Details for sensitivity parameters.
/// </summary>
public record SensitivityParameters
{
    /// <summary>
    /// The maximum value of the threshold in the units being measured.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("abnormalMaxValue")]
    public double? AbnormalMaxValue { get; init; }

    /// <summary>
    /// If abnormal values are being monitored.&lt;br /&gt;true - Monitor for abnormal values&lt;br /&gt;false - Do not monitor for abnormal values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enableAbnormal")]
    public bool? EnableAbnormal { get; init; }

    /// <summary>
    /// If very abnormal values are being monitored.&lt;br /&gt;true - Monitor for very abnormal values&lt;br /&gt;false - Do not monitor for very abnormal values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enableVeryAbnormal")]
    public bool? EnableVeryAbnormal { get; init; }

    /// <summary>
    /// The maximum value of the threshold in the units being measured.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("veryAbnormalMaxValue")]
    public double? VeryAbnormalMaxValue { get; init; }
}
