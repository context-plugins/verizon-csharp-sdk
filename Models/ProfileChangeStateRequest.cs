using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record ProfileChangeStateRequest
{
    [JsonPropertyName("devices")]
    public required IReadOnlyList<DeviceList> Devices { get; init; }

    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    [JsonPropertyName("smsrOid")]
    public required string SmsrOid { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
