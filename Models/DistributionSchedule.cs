using System;
using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// The distribution schedule parameters for broadcast messages.
/// </summary>
public record DistributionSchedule
{
    /// <summary>
    /// The period (in seconds) that the message needs to be repeatedly send out.
    /// </summary>
    [JsonPropertyName("repeatPeriod")]
    [Minimum(5)]
    [Maximum(3600)]
    public required int RepeatPeriod { get; init; }

    /// <summary>
    /// The amount of time (in minutes) while the messages needs to be sent out.
    /// </summary>
    [JsonPropertyName("duration")]
    [Minimum(1)]
    [Maximum(32000)]
    public required int Duration { get; init; }

    /// <summary>
    /// The time (in UTC) when the message transmission should be started.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startTime")]
    public DateTimeOffset? StartTime { get; init; }
}
