using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Indicates the type of asphalt or tar.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type7>))]
public sealed record Type7 : StringEnum<Type7>
{
    private Type7(string value) : base(value)
    {
    }

    public static readonly Type7 NewSharp = new("newSharp");

    public static readonly Type7 Traveled = new("traveled");

    public static readonly Type7 TrafficPolished = new("trafficPolished");

    public static readonly Type7 ExcessTar = new("excessTar");

    public static Type7 FromValue(string value) => FromValueCore(value);
}
