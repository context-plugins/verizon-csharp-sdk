using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Accountnames
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountNameList")]
    public IReadOnlyList<string>? AccountNameList { get; init; }
}
