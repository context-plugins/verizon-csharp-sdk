using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DtoQueryMetricsResponse
{
    /// <summary>
    /// The number of critical alerts in the queried time period
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("critical")]
    public int? Critical { get; init; }

    /// <summary>
    /// The number of major alerts in the queried time period
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("major")]
    public int? Major { get; init; }

    /// <summary>
    /// The number of minor alerts in the queried time period
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minor")]
    public int? Minor { get; init; }

    /// <summary>
    /// The number of sensor reports containing no  alerts in the queried time period
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("noalert")]
    public int? Noalert { get; init; }

    /// <summary>
    /// The total number of alerts in the queried time period
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total")]
    public int? Total { get; init; }

    /// <summary>
    /// The change in the number of critical alerts in the queried time period
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deltacritical")]
    public int? Deltacritical { get; init; }

    /// <summary>
    /// The change in the number of major alerts in the queried time period
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deltamajor")]
    public int? Deltamajor { get; init; }

    /// <summary>
    /// The change in the number of minor alerts in the queried time period
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deltaminor")]
    public int? Deltaminor { get; init; }

    /// <summary>
    /// The change in the number of sensor reports containing no alerts in the queried time period
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deltanoalert")]
    public int? Deltanoalert { get; init; }
}
