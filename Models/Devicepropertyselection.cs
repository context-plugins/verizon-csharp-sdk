using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record Devicepropertyselection
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modelid")]
    public string? Modelid { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
