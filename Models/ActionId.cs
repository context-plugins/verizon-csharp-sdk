using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record ActionId
{
    /// <summary>
    /// Unique ID for originating station.
    /// </summary>
    [JsonPropertyName("originatingStationId")]
    public required int OriginatingStationId { get; init; }

    /// <summary>
    /// Counter used to differenciate multiple DENMs from same station.
    /// </summary>
    [JsonPropertyName("sequenceNumber")]
    public required int SequenceNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
