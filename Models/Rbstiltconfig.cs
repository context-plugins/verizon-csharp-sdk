using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Rbstiltconfig
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("RbsHighPrecisionTiltConfig")]
    public RbsHighPrecisionTiltConfig? RbsHighPrecisionTiltConfig { get; init; }
}
