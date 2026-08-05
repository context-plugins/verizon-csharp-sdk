using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The boolean of the comparison. <c>gt</c> is Greater Than, <c>lt</c> is Less Than and <c>eq</c> is Equal To
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Comparitor>))]
public sealed record Comparitor : StringEnum<Comparitor>
{
    private Comparitor(string value) : base(value)
    {
    }

    public static readonly Comparitor Gt = new("gt");

    public static readonly Comparitor Lt = new("lt");

    public static readonly Comparitor Eq = new("eq");

    public static Comparitor FromValue(string value) => FromValueCore(value);
}
