using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DailyUsageResponse
{
    /// <summary>
    /// A flag set to indicate if there is more than one page of data returned by the query (true) or if only one page of data returned (false)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hasMoreData")]
    public bool? HasMoreData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceId")]
    public GiodeviceId? DeviceId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usageHistory")]
    public IReadOnlyList<DailyUsageHistory>? UsageHistory { get; init; }
}
