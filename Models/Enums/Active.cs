using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// A flag to indicate of the trigger is active, true, or not, false
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Active>))]
public sealed record Active : StringEnum<Active>
{
    private Active(string value) : base(value)
    {
    }

    public static readonly Active True = new("true");

    public static readonly Active False = new("false");

    public static Active FromValue(string value) => FromValueCore(value);
}
