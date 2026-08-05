using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// A success response includes an array of all matching events.
/// </summary>
public record SearchDeviceEventHistoryResponseList
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SearchDeviceEventHistory")]
    [MaxLength(100)]
    public IReadOnlyList<SearchDeviceResponse>? SearchDeviceEventHistory { get; init; }
}
