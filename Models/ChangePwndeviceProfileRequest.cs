using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ChangePwndeviceProfileRequest
{
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    [JsonPropertyName("deviceList")]
    public required IReadOnlyList<PwndeviceList> DeviceList { get; init; }

    [JsonPropertyName("newProfile")]
    public required string NewProfile { get; init; }
}
