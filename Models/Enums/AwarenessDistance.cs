using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Specifies how far the event is relevant to.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AwarenessDistance>))]
public sealed record AwarenessDistance : StringEnum<AwarenessDistance>
{
    private AwarenessDistance(string value) : base(value)
    {
    }

    public static readonly AwarenessDistance LessThan50M = new("lessThan50m");

    public static readonly AwarenessDistance LessThan100M = new("lessThan100m");

    public static readonly AwarenessDistance LessThan200M = new("lessThan200m");

    public static readonly AwarenessDistance LessThan500M = new("lessThan500m");

    public static readonly AwarenessDistance LessThan1000M = new("lessThan1000m");

    public static readonly AwarenessDistance LessThan5Km = new("lessThan5km");

    public static readonly AwarenessDistance LessThan10Km = new("lessThan10km");

    public static readonly AwarenessDistance Over10Km = new("over10km");

    public static AwarenessDistance FromValue(string value) => FromValueCore(value);
}
