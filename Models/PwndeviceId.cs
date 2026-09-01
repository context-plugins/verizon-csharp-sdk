using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record PwnDeviceId
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("kind")]
    public required string Kind { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
