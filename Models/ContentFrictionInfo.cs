using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ContentFrictionInfo
{
    [JsonPropertyName("frictionInfo")]
    public required FrictionInformation FrictionInfo { get; init; }
}
