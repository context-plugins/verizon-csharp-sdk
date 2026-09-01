using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Used to filter data by time period or number of devices.
/// </summary>
public record HistorySearchRequest
{
    /// <summary>
    /// The selected device and attributes for which a request should retrieve data.
    /// </summary>
    [JsonPropertyName("$filter")]
    public required HistorySearchFilter Filter { get; init; }

    /// <summary>
    /// The maximum number of historical attributes to include in the response. If the request matches more than this number of attributes, the response will contain an X-Next value in the header that can be used as the page value in the next request to retrieve the next page of events.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("$limitNumber")]
    public int? LimitNumber { get; init; }

    /// <summary>
    /// The time period for which a request should retrieve data, beginning with the limitTime.startOn and proceeding with the limitTime.duration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("$limitTime")]
    public HistorySearchLimitTime? LimitTime { get; init; }

    /// <summary>
    /// Page number for pagination purposes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("$page")]
    public string? Page { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
