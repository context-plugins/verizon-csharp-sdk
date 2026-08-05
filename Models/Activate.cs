using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Activate
{
    [JsonPropertyName("profile")]
    public required string Profile { get; init; }
}
