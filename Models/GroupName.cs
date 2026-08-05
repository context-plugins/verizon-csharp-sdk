using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GroupName
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Default")]
    public string? Default { get; init; }
}
