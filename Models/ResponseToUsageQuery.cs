using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ResponseToUsageQuery
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hasmoredata")]
    public bool? Hasmoredata { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceId")]
    public ReadySimDeviceId? DeviceId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usageHistory")]
    public IReadOnlyList<UsageHistory>? UsageHistory { get; init; }
}
