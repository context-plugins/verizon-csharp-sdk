using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DeviceListIp
{
    [JsonPropertyName("deviceIds")]
    public required IReadOnlyList<PwndeviceId> DeviceIds { get; init; }

    [JsonPropertyName("ipAddress")]
    public required string IpAddress { get; init; }
}
