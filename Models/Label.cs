using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Label
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9]{3,32}$")]
    public string? Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9]{3,32}$")]
    public string? Value { get; init; }
}
