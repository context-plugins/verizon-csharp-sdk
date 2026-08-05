using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Indicates the type of snow.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type13>))]
public sealed record Type13 : StringEnum<Type13>
{
    private Type13(string value) : base(value)
    {
    }

    public static readonly Type13 Packed = new("packed");

    public static readonly Type13 Loose = new("loose");

    public static Type13 FromValue(string value) => FromValueCore(value);
}
