using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GenerateResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("items")]
    public IReadOnlyList<GenerateResponseItem>? Items { get; init; }
}
