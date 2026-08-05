using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<CycleType>))]
public sealed record CycleType : StringEnum<CycleType>
{
    private CycleType(string value) : base(value)
    {
    }

    public static readonly CycleType Cycleone = new("cycleone");

    public static readonly CycleType Cycletwo = new("cycletwo");

    public static CycleType FromValue(string value) => FromValueCore(value);
}
