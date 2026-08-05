using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The interval to monitor for the threshold. This can be Daily, Weekly or Monthly
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RulesCycleType>))]
public sealed record RulesCycleType : StringEnum<RulesCycleType>
{
    private RulesCycleType(string value) : base(value)
    {
    }

    public static readonly RulesCycleType Daily = new("Daily");

    public static readonly RulesCycleType Weekly = new("Weekly");

    public static readonly RulesCycleType Monthly = new("Monthly");

    public static RulesCycleType FromValue(string value) => FromValueCore(value);
}
