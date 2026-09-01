using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record Devicepropertyfilter
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("$selection")]
    public Devicepropertyselection? Selection { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("$querytotalcount")]
    public bool? Querytotalcount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
