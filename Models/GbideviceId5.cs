using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GbideviceId5
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceId")]
    public GbideviceId15? DeviceId { get; init; }
}
