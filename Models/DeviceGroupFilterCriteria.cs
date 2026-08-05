using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DeviceGroupFilterCriteria
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filterCriteria")]
    public DeviceGroupFilter? FilterCriteria { get; init; }
}
