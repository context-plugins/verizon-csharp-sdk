using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// The payload of the DENM PDU.
/// </summary>
public record DenmPayload
{
    /// <summary>
    /// This represent the management container describing the meta information about the event, such as the detection time, the event's location, the source of the event, and the notification distance.
    /// </summary>
    [JsonPropertyName("management")]
    public required Management Management { get; init; }

    /// <summary>
    /// This represents the situation container describing the event and the reliability of the detection source.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("situation")]
    public Situation? Situation { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
