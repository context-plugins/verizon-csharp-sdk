using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Indicates the type of gravel.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type8>))]
public sealed record Type8 : StringEnum<Type8>
{
    private Type8(string value) : base(value)
    {
    }

    public static readonly Type8 PackedOiled = new("packedOiled");

    public static readonly Type8 Loose = new("loose");

    public static Type8 FromValue(string value) => FromValueCore(value);
}
