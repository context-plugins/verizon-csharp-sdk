using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type3>))]
public sealed record Type3 : StringEnum<Type3>
{
    private Type3(string value) : base(value)
    {
    }

    public static readonly Type3 Polygon = new("Polygon");

    public static Type3 FromValue(string value) => FromValueCore(value);
}
