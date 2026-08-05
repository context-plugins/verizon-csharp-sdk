using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Possible values are <c>append</c> or <c>remove</c>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FirmwareTypeList>))]
public sealed record FirmwareTypeList : StringEnum<FirmwareTypeList>
{
    private FirmwareTypeList(string value) : base(value)
    {
    }

    public static readonly FirmwareTypeList Append = new("append");

    public static readonly FirmwareTypeList Remove = new("remove");

    public static FirmwareTypeList FromValue(string value) => FromValueCore(value);
}
