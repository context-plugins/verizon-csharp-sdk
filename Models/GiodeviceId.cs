using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GiodeviceId
{
    [JsonPropertyName("kind")]
    public required string Kind { get; init; }

    [JsonPropertyName("id")]
    public required string Id { get; init; }
}
