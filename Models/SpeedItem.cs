using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Defines the acceptable speed range for road users in m/s. Messages are triggered when:
///     1. The road user's speed is below the required minimum OR
///     2. The road user's speed is above the acceptable maximum AND
///     3. The associated TriggerConditions are met.
/// <para>
/// Example: For the speed range of 10-20 m/s and a TriggerCondition of 'user inside geofence', the message is sent if the user's speed is below 10 m/s or above 20 m/s while in the geofence area.
/// </para>
/// </summary>
public record SpeedItem
{
    /// <summary>
    /// Acceptable speed range for road users in m/s.
    /// </summary>
    [JsonPropertyName("speed")]
    public required SpeedRange? Speed { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
