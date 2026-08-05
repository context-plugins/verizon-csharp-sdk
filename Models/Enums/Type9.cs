using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Indicates the surface of the roadway is grass with low speed limit.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type9>))]
public sealed record Type9 : StringEnum<Type9>
{
    private Type9(string value) : base(value)
    {
    }

    public static readonly Type9 LessThan30Mph = new("lessThan30Mph");

    public static Type9 FromValue(string value) => FromValueCore(value);
}
