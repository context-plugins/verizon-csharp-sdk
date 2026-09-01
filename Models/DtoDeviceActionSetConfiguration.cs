using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record DtoDeviceActionSetConfiguration
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceConfig")]
    public DtoDeviceConfig? DeviceConfig { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
