using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Indicates the type of portland cement.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type6>))]
public sealed record Type6 : StringEnum<Type6>
{
    private Type6(string value) : base(value)
    {
    }

    public static readonly Type6 NewSharp = new("newSharp");

    public static readonly Type6 Traveled = new("traveled");

    public static readonly Type6 TrafficPolished = new("trafficPolished");

    public static Type6 FromValue(string value) => FromValueCore(value);
}
