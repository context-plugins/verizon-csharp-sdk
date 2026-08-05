using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// The EUI64 address of the device being removed
/// </summary>
public record DtoOffBoardSensor
{
    /// <summary>
    /// the IEEE EUI64 address space used to identify a device. It is supplied by the device manufacturer
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deveui")]
    public string? Deveui { get; init; }
}
