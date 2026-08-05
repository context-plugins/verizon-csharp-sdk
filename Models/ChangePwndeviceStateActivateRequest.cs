using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ChangePwndeviceStateActivateRequest
{
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    [JsonPropertyName("deviceList")]
    public required IReadOnlyList<PwndeviceList> DeviceList { get; init; }

    [JsonPropertyName("activate")]
    public required Activate Activate { get; init; }
}
