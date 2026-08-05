using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Devicepropertyselection
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modelid")]
    public string? Modelid { get; init; }
}
