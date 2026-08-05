using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// The configuration of the remove request
/// </summary>
public record Sensorinsightsconfig
{
    /// <summary>
    /// The EUI64 address of the device being removed
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("removesensor")]
    public DtoOffBoardSensor? Removesensor { get; init; }
}
