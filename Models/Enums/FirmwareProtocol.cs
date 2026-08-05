using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Firmware protocol. Valid values include: LWM2M, OMD-DM, all.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FirmwareProtocol>))]
public sealed record FirmwareProtocol : StringEnum<FirmwareProtocol>
{
    private FirmwareProtocol(string value) : base(value)
    {
    }

    public static readonly FirmwareProtocol Lwm2M = new("LWM2M");

    public static readonly FirmwareProtocol OmdDm = new("OMD-DM");

    public static readonly FirmwareProtocol All = new("all");

    public static FirmwareProtocol FromValue(string value) => FromValueCore(value);
}
