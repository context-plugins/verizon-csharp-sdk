using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DtoDeviceActionSetResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actionresult")]
    public IReadOnlyList<ActionResultwithDeviceConfig>? Actionresult { get; init; }
}
