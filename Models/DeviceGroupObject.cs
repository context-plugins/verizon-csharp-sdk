using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record DeviceGroupObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceGroup")]
    public DeviceGroupFilterCriteria? DeviceGroup { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
