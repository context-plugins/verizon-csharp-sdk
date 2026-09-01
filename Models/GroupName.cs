using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record GroupName
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Default")]
    public string? Default { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
