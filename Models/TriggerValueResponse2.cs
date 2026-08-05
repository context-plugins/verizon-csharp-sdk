using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Models.AnyOf;

namespace Verizon.Models;

public record TriggerValueResponse2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggers")]
    public IReadOnlyList<TriggervalueChunk2>? Triggers { get; init; }
}
