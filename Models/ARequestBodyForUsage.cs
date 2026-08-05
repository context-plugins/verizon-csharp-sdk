using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ARequestBodyForUsage
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceId")]
    public IReadOnlyList<ReadySimDeviceId>? DeviceId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startTime")]
    public DateTimeOffset? StartTime { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endTime")]
    public DateTimeOffset? EndTime { get; init; }
}
