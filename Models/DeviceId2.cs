using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DeviceId2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("kind")]
    public string? Kind { get; init; }
}
