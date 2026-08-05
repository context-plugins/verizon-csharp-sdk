using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Subrequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ids")]
    public GiodeviceId? Ids { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    [StringLength(8, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z]{3,8}$")]
    public string? Status { get; init; }
}
