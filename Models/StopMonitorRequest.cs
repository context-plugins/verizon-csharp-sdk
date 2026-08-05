using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record StopMonitorRequest
{
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    [JsonPropertyName("devices")]
    public required IReadOnlyList<DeviceList> Devices { get; init; }
}
