using System;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record SmseventHistoryRequest
{
    [JsonPropertyName("deviceId")]
    public required GiodeviceId DeviceId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("earliest")]
    public DateTimeOffset? Earliest { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("latest")]
    public DateTimeOffset? Latest { get; init; }
}
