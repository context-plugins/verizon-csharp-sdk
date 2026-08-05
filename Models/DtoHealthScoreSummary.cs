using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// The values measured are for sensors and gateways
/// </summary>
public record DtoHealthScoreSummary
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("overallsummary")]
    [MaxLength(100)]
    public IReadOnlyList<DtoHealthScoreMetric>? Overallsummary { get; init; }
}
