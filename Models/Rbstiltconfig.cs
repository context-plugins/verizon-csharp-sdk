using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record Rbstiltconfig
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("RbsHighPrecisionTiltConfig")]
    public RbsHighPrecisionTiltConfig? RbsHighPrecisionTiltConfig { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
