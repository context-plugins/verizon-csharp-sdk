using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record ChangePwnDeviceIPaddressRequest
{
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    [JsonPropertyName("deviceList")]
    public required IReadOnlyList<DeviceListIp> DeviceList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
