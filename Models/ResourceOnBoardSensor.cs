using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ResourceOnBoardSensor
{
    /// <summary>
    /// the IEEE EUI64 address space used to identify a device. It is supplied by the device manufacturer
    /// </summary>
    [JsonPropertyName("deveui")]
    public required string Deveui { get; init; }

    /// <summary>
    /// global application ID in IEEE EUI64 address space that uniquely identifies the entity able to process the JoinReq frame
    /// </summary>
    [JsonPropertyName("appeui")]
    public required string Appeui { get; init; }

    /// <summary>
    /// an encryption key used for messages during every over the air activation
    /// </summary>
    [JsonPropertyName("appkey")]
    public required string Appkey { get; init; }

    /// <summary>
    /// Class of the sensor device. Valid values are Class A (A), Class B (B), and Class C (C). All LoRaWAN devices must implement Class A
    /// </summary>
    [JsonPropertyName("class")]
    public required string Class { get; init; }

    /// <summary>
    /// The kind of sensor device
    /// </summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; init; }

    [JsonPropertyName("description")]
    public required string Description { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Name/value pair, where the value is client defined.  The purpose is to keep track of current state per device action.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customdata")]
    public IReadOnlyDictionary<string, object>? Customdata { get; init; }
}
