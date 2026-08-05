using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DataTrigger
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountLevel")]
    public AccountLevelObject? AccountLevel { get; init; }
}
