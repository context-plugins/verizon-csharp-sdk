using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The action taken when trigger conditions are met
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountLevelAction>))]
public sealed record AccountLevelAction : StringEnum<AccountLevelAction>
{
    private AccountLevelAction(string value) : base(value)
    {
    }

    public static readonly AccountLevelAction Notify = new("notify");

    public static readonly AccountLevelAction Suspend = new("suspend");

    public static readonly AccountLevelAction ChangePricePlan = new("changePricePlan");

    public static AccountLevelAction FromValue(string value) => FromValueCore(value);
}
