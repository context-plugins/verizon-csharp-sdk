using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record DataTrigger
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountLevel")]
    public AccountLevelObject? AccountLevel { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
