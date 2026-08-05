using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Unit of time.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NumericalDataUnit>))]
public sealed record NumericalDataUnit : StringEnum<NumericalDataUnit>
{
    private NumericalDataUnit(string value) : base(value)
    {
    }

    public static readonly NumericalDataUnit Second = new("SECOND");

    public static readonly NumericalDataUnit Minute = new("MINUTE");

    public static readonly NumericalDataUnit Hour = new("HOUR");

    public static readonly NumericalDataUnit Day = new("DAY");

    public static NumericalDataUnit FromValue(string value) => FromValueCore(value);
}
