using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DtoDeviceActionSetConfiguration1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceConfig")]
    public DtoDeviceConfig? DeviceConfig { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("RbsHighPrecisionTiltConfig")]
    public RbsHighPrecisionTiltConfig? RbsHighPrecisionTiltConfig { get; init; }
}
