using System.Text.Json.Serialization;

namespace Verizon.Models;

public record FieldsHttpHeaders
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Authorization")]
    public string? Authorization { get; init; }
}
