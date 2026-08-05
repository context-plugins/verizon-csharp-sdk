using System.Text.Json.Serialization;

namespace Verizon.Models;

public record EnablePromoExp1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enablePromoExp")]
    public bool? EnablePromoExp { get; init; }
}
