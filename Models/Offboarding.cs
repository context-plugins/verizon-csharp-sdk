using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record Offboarding
{
    /// <summary>
    /// the IEEE EUI64 address space used to identify a device. It is supplied by the device manufacturer
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sensoridentifier")]
    public string? Sensoridentifier { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
