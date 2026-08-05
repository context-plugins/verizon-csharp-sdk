using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ResourceResourceQuery
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public Devicepropertyfilter? Filter { get; init; }
}
