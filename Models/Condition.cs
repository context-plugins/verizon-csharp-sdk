using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Condition
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("condition")]
    public IReadOnlyList<Keyschunk2>? ConditionValue { get; init; }
}
