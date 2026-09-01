using System.Text.Json.Serialization;
using Verizon.Core.Models;

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
