using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DeviceGroupObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceGroup")]
    public DeviceGroupFilterCriteria? DeviceGroup { get; init; }
}
