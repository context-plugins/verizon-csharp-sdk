using System.Text.Json.Serialization;

namespace Verizon.Models;

public record PwndeviceId
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("kind")]
    public required string Kind { get; init; }
}
