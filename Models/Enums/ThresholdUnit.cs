using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The units of the threshold. This can be KB, Kilobits, MB, Megabits, or GB, Gigabits
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ThresholdUnit>))]
public sealed record ThresholdUnit : StringEnum<ThresholdUnit>
{
    private ThresholdUnit(string value) : base(value)
    {
    }

    public static readonly ThresholdUnit Kb = new("KB");

    public static readonly ThresholdUnit Mb = new("MB");

    public static readonly ThresholdUnit Gb = new("GB");

    public static ThresholdUnit FromValue(string value) => FromValueCore(value);
}
