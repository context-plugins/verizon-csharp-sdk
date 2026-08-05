using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record NotificationReportRequest
{
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    [JsonPropertyName("requestType")]
    public required string RequestType { get; init; }

    [JsonPropertyName("devices")]
    public required IReadOnlyList<DeviceList> Devices { get; init; }

    [JsonPropertyName("monitorExpirationTime")]
    public required string MonitorExpirationTime { get; init; }
}
