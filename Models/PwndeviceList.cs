using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record PwndeviceList
{
    [JsonPropertyName("deviceIds")]
    public required IReadOnlyList<PwndeviceId> DeviceIds { get; init; }
}
