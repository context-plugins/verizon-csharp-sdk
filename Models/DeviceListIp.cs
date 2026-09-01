using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record DeviceListIp
{
    [JsonPropertyName("deviceIds")]
    public required IReadOnlyList<PwnDeviceId> DeviceIds { get; init; }

    [JsonPropertyName("ipAddress")]
    public required string IpAddress { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
