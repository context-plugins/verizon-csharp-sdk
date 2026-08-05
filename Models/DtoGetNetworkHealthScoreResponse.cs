using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// The values measured are for the network
/// </summary>
public record DtoGetNetworkHealthScoreResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networksummary")]
    [MaxLength(100)]
    public IReadOnlyList<DtoHealthScoreMetric>? Networksummary { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("overallsummary")]
    [MaxLength(100)]
    public IReadOnlyList<DtoHealthScoreMetric>? Overallsummary { get; init; }
}
