using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GbideviceIdarray5
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceId")]
    public IReadOnlyList<DeviceId>? DeviceId { get; init; }
}
