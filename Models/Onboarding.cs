using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Onboarding
{
    /// <summary>
    /// the IEEE EUI64 address space used to identify a device. It is supplied by the device manufacturer
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sensoridentifier")]
    public string? Sensoridentifier { get; init; }
}
