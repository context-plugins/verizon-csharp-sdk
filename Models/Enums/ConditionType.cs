using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The condition type being monitored
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConditionType>))]
public sealed record ConditionType : StringEnum<ConditionType>
{
    private ConditionType(string value) : base(value)
    {
    }

    public static readonly ConditionType Individual = new("Individual");

    public static readonly ConditionType Aging = new("Aging");

    public static readonly ConditionType UsageAllowance = new("UsageAllowance");

    public static ConditionType FromValue(string value) => FromValueCore(value);
}
