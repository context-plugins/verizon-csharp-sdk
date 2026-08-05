using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ProfileChangeStateRequest
{
    [JsonPropertyName("devices")]
    public required IReadOnlyList<DeviceList> Devices { get; init; }

    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    [JsonPropertyName("smsrOid")]
    public required string SmsrOid { get; init; }
}
