using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type2>))]
public sealed record Type2 : StringEnum<Type2>
{
    private Type2(string value) : base(value)
    {
    }

    public static readonly Type2 LineString = new("LineString");

    public static Type2 FromValue(string value) => FromValueCore(value);
}
