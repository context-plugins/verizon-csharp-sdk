using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Indicates the type of rock.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type11>))]
public sealed record Type11 : StringEnum<Type11>
{
    private Type11(string value) : base(value)
    {
    }

    public static readonly Type11 Crushed = new("crushed");

    public static Type11 FromValue(string value) => FromValueCore(value);
}
