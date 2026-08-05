using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record RetrieveResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("items")]
    public IReadOnlyList<RetrieveResponseItem>? Items { get; init; }
}
