using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record SubscribeRequest
{
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    [JsonPropertyName("deviceInfo")]
    public required IReadOnlyList<QosdeviceInfo> DeviceInfo { get; init; }
}
