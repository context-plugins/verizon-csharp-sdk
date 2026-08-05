using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DropResponseItem
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("imei")]
    public string? Imei { get; init; }
}
