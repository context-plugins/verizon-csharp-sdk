using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Location cache mode.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CacheMode>))]
public sealed record CacheMode : StringEnum<CacheMode>
{
    private CacheMode(string value) : base(value)
    {
    }

    public static readonly CacheMode _0 = new("0");

    public static readonly CacheMode _1 = new("1");

    public static readonly CacheMode _2 = new("2");

    public static CacheMode FromValue(string value) => FromValueCore(value);
}
