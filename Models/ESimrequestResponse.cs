using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ESimrequestResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestId")]
    public string? RequestId { get; init; }
}
