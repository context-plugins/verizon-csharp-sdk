using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DtoOffBoardSensorRequest
{
    /// <summary>
    /// The numeric account name, which must include leading zeros
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountname")]
    public string? Accountname { get; init; }

    /// <summary>
    /// The configuration of the remove request
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("configuration")]
    public Sensorinsightsconfig? Configuration { get; init; }
}
