using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Indicates the type of ice.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type12>))]
public sealed record Type12 : StringEnum<Type12>
{
    private Type12(string value) : base(value)
    {
    }

    public static readonly Type12 Smooth = new("smooth");

    public static Type12 FromValue(string value) => FromValueCore(value);
}
