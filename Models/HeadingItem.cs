using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Heading limitation provides minimum and maximum value for road user heading in unit of degrees. If the road user's heading value is between the given minimum and maximum value and the TriggerConditions are also met the message will be sent out.
/// <para>
/// The heading minimum value can be bigger than the maximum value as negative number are not supported. For example, the +/- 10 degrees around the north (0 degrees) can be defined as 350 (min) to 10 (max) degrees.
/// </para>
/// </summary>
public record HeadingItem
{
    /// <summary>
    /// Acceptable heading range for road users in degrees.
    /// </summary>
    [JsonPropertyName("heading")]
    public required HeadingRange? Heading { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
