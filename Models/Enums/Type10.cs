using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Indicates the type of cinders.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type10>))]
public sealed record Type10 : StringEnum<Type10>
{
    private Type10(string value) : base(value)
    {
    }

    public static readonly Type10 Packed = new("packed");

    public static Type10 FromValue(string value) => FromValueCore(value);
}
