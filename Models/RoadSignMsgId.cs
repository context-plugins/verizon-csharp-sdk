using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Message ID referencing a road sign location.
/// </summary>
public record RoadSignMsgId
{
    /// <summary>
    /// It provide a precise location of one or more roadside signs.
    /// </summary>
    [JsonPropertyName("roadSignID")]
    public required RoadSignId RoadSignId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
