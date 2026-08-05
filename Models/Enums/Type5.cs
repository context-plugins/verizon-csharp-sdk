using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type5>))]
public sealed record Type5 : StringEnum<Type5>
{
    private Type5(string value) : base(value)
    {
    }

    public static readonly Type5 MultiPolygon = new("MultiPolygon");

    public static Type5 FromValue(string value) => FromValueCore(value);
}
