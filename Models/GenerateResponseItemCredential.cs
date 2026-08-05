using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GenerateResponseItemCredential
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("username")]
    public string? Username { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("password")]
    public string? Password { get; init; }
}
