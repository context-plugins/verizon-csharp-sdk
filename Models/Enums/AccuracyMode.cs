using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Accurary, currently only 0-coarse supported.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccuracyMode>))]
public sealed record AccuracyMode : StringEnum<AccuracyMode>
{
    private AccuracyMode(string value) : base(value)
    {
    }

    public static readonly AccuracyMode _0 = new("0");

    public static AccuracyMode FromValue(string value) => FromValueCore(value);
}
