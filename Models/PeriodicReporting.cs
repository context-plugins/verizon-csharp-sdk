using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// The units and values of the time interval for the sensor to send a report
/// </summary>
public record PeriodicReporting
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unit")]
    public Unit? Unit { get; init; }

    /// <summary>
    /// whole numbers from 0 to 24
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hours")]
    public int? Hours { get; init; }

    /// <summary>
    /// whole numbers from 0 to 59
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minutes")]
    public int? Minutes { get; init; }
}
