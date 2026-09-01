using System;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record SmsEventHistoryRequest
{
    [JsonPropertyName("deviceId")]
    public required GioDeviceId DeviceId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("earliest")]
    public DateTimeOffset? Earliest { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("latest")]
    public DateTimeOffset? Latest { get; init; }
}
