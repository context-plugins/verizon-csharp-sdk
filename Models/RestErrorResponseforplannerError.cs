using System.Text.Json.Serialization;

namespace Verizon.Models;

public record RestErrorResponseforplannerError
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorUrl")]
    public string? ErrorUrl { get; init; }
}
