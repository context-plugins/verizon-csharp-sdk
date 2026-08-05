using System.Text.Json.Serialization;

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
}
