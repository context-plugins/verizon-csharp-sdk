using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GbideviceIdarray25
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceId")]
    public IReadOnlyList<GbideviceId15>? DeviceId { get; init; }
}
