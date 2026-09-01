using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record ContentFrictionInfo
{
    [JsonPropertyName("frictionInfo")]
    public required FrictionInformation FrictionInfo { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
