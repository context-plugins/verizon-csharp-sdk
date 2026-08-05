using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DtoDeviceActionSetConfiguration
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceConfig")]
    public DtoDeviceConfig? DeviceConfig { get; init; }
}
