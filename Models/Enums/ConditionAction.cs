using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The action taken when trigger conditions are met
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConditionAction>))]
public sealed record ConditionAction : StringEnum<ConditionAction>
{
    private ConditionAction(string value) : base(value)
    {
    }

    public static readonly ConditionAction Notify = new("notify");

    public static readonly ConditionAction Suspend = new("suspend");

    public static readonly ConditionAction ChangePricePlan = new("changePricePlan");

    public static ConditionAction FromValue(string value) => FromValueCore(value);
}
