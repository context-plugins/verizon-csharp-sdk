using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Models.AnyOf;

namespace Verizon.Models;

public record TriggerValueResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggers")]
    public IReadOnlyList<TriggervalueChunk>? Triggers { get; init; }
}
