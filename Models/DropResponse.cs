using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DropResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("items")]
    public IReadOnlyList<DropResponseItem>? Items { get; init; }
}
