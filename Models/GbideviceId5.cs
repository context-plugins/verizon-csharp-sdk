using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record GbideviceId5
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceId")]
    public GbideviceId15? DeviceId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
