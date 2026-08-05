using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Used to define callbacks including the device identity, the attribute names, corresponding attribute values and the date/timestamp of when the observation was made.
/// </summary>
public record ObservationRequest
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// List of devices.
    /// </summary>
    [JsonPropertyName("devices")]
    public required IReadOnlyList<Device> Devices { get; init; }

    /// <summary>
    /// Attributes are streaming RF parameters that you want to observe.
    /// </summary>
    [JsonPropertyName("attributes")]
    public required IReadOnlyList<ObservationRequestAttribute> Attributes { get; init; }

    /// <summary>
    /// Describes value and unit of time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frequency")]
    public NumericalData? Frequency { get; init; }

    /// <summary>
    /// Describes value and unit of time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("duration")]
    public NumericalData? Duration { get; init; }
}
