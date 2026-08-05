using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record QosdeviceInfo
{
    [JsonPropertyName("deviceId")]
    public required QosdeviceId DeviceId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceIPv6Addr")]
    public string? DeviceIpv6Addr { get; init; }

    [JsonPropertyName("flowInfo")]
    public required IReadOnlyList<FlowInfo> FlowInfo { get; init; }
}
