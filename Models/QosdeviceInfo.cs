using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record QoSdeviceInfo
{
    [JsonPropertyName("deviceId")]
    public required QoSdeviceId DeviceId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceIPv6Addr")]
    public string? DeviceIPv6Addr { get; init; }

    [JsonPropertyName("flowInfo")]
    public required IReadOnlyList<FlowInfo> FlowInfo { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
