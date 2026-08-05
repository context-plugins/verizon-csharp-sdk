using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ErrorResponseModel
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responseCode")]
    public string? ResponseCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }
}
