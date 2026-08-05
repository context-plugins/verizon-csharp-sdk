using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The distribution types:
///   - Targeted: Generate targeted messages to the road users that are affected by the zone rules
///   - Broadcast: Broadcast messages to regions based on the Geofence.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DistributionTypes>))]
public sealed record DistributionTypes : StringEnum<DistributionTypes>
{
    private DistributionTypes(string value) : base(value)
    {
    }

    public static readonly DistributionTypes Targeted = new("Targeted");

    public static readonly DistributionTypes Broadcast = new("Broadcast");

    public static DistributionTypes FromValue(string value) => FromValueCore(value);
}
