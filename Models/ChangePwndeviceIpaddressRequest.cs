using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ChangePwndeviceIpaddressRequest
{
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    [JsonPropertyName("deviceList")]
    public required IReadOnlyList<DeviceListIp> DeviceList { get; init; }
}
