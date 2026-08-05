using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Unit>))]
public sealed record Unit : StringEnum<Unit>
{
    private Unit(string value) : base(value)
    {
    }

    public static readonly Unit Minutes = new("minutes");

    public static readonly Unit Hours = new("hours");

    public static Unit FromValue(string value) => FromValueCore(value);
}
