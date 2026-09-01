using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record Activate
{
    [JsonPropertyName("profile")]
    public required string Profile { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
