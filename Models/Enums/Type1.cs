using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type1>))]
public sealed record Type1 : StringEnum<Type1>
{
    private Type1(string value) : base(value)
    {
    }

    public static readonly Type1 Feature = new("Feature");

    public static Type1 FromValue(string value) => FromValueCore(value);
}
