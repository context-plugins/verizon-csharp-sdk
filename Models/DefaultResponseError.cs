using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DefaultResponseError
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; init; }
}
