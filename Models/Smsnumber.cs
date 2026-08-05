using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Notification SMS details.
/// </summary>
public record Smsnumber
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrier")]
    public string? Carrier { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    public string? Number { get; init; }
}
