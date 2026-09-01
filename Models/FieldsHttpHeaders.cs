using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record FieldsHttpHeaders
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Authorization")]
    public string? Authorization { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
