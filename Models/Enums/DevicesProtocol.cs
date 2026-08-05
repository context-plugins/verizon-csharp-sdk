using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Firmware protocol. Valid values include: LWM2M, OMADM, HTTP.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DevicesProtocol>))]
public sealed record DevicesProtocol : StringEnum<DevicesProtocol>
{
    private DevicesProtocol(string value) : base(value)
    {
    }

    public static readonly DevicesProtocol Lwm2M = new("LWM2M");

    public static readonly DevicesProtocol Omdadm = new("OMDADM");

    public static readonly DevicesProtocol Http = new("HTTP");

    public static DevicesProtocol FromValue(string value) => FromValueCore(value);
}
