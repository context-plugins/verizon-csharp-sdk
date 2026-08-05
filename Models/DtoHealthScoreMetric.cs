using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DtoHealthScoreMetric
{
    /// <summary>
    /// The type of measurement and can be overallscore, networkscore, gatewayscore, sensorscore, networkstatus, averagesignalstrength or networkavailabilitylast30
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metrictype")]
    public string? Metrictype { get; init; }

    /// <summary>
    /// the value of the <c>metrictype</c> as a percentage
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metricvalue")]
    public string? Metricvalue { get; init; }
}
