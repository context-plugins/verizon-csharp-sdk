using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GiorequestResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestId")]
    [StringLength(64, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9\\-]{3,64}$")]
    public string? RequestId { get; init; }
}
