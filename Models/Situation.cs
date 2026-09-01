using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// This represents the situation container describing the event and the reliability of the detection source.
/// </summary>
public record Situation
{
    /// <summary>
    /// The quality or reliability level of the information provided by the ITS-S application of the originating ITS-S.
    /// </summary>
    [JsonPropertyName("informationQuality")]
    [Minimum(0)]
    [Maximum(7)]
    public required int InformationQuality { get; init; }

    /// <summary>
    /// The type of event including direct and sub cause.
    /// </summary>
    [JsonPropertyName("eventType")]
    public required EventType EventType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
