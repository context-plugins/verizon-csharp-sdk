using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// the reporting mode of the tilt sensor
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Mode>))]
public sealed record Mode : StringEnum<Mode>
{
    private Mode(string value) : base(value)
    {
    }

    public static readonly Mode ReportOnChange = new("reportOnChange");

    public static Mode FromValue(string value) => FromValueCore(value);
}
