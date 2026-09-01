using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record RbsHighPrecisionTiltConfig
{
    /// <summary>
    /// the reporting mode of the tilt sensor
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mode")]
    public Mode? Mode { get; init; }

    /// <summary>
    /// The units and values of the time interval for the sensor to send a report
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("periodic-reporting")]
    public PeriodicReporting? PeriodicReporting { get; init; }

    /// <summary>
    /// The time the threshold condition exists, in milliseconds, to recognize an event
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hold-time")]
    public int? HoldTime { get; init; }

    /// <summary>
    /// the threshold value, from verticle, to recognize an event
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("angle-away")]
    public int? AngleAway { get; init; }

    /// <summary>
    /// the threshold value, moving towards  verticle, to recognize an event
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("angle-toward")]
    public int? AngleToward { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tscore")]
    public Tscore? Tscore { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
