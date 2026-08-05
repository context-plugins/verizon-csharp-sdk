using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The type of the device's network connection at the time of the request. If the device is on the Verizon cellular network it should use the "VZ" value otherwise the "non-VZ" value.
/// <para>
/// Devices on the Verizon network can directly access the ETX Message Exchange on the MEC (Mobile Edge Compute server)
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NetworkType>))]
public sealed record NetworkType : StringEnum<NetworkType>
{
    private NetworkType(string value) : base(value)
    {
    }

    public static readonly NetworkType Vz = new("VZ");

    public static readonly NetworkType NonVz = new("non-VZ");

    public static NetworkType FromValue(string value) => FromValueCore(value);
}
