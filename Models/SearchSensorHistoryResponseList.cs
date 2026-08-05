using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// A success response includes an array of all matching events.
/// </summary>
public record SearchSensorHistoryResponseList
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SearchSensorHistory")]
    [MaxLength(100)]
    public IReadOnlyList<SearchDeviceResponse>? SearchSensorHistory { get; init; }
}
