using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record ActionObjectCall
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("action")]
    public Actionobject? Action { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
