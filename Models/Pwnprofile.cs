using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Pwnprofile
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profileId")]
    public string? ProfileId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profileName")]
    public string? ProfileName { get; init; }
}
