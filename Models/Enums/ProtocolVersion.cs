using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The protocol version of the DENM.
/// </summary>
[JsonConverter(typeof(IntEnumConverter<ProtocolVersion>))]
public sealed record ProtocolVersion : IntEnum<ProtocolVersion>
{
    private ProtocolVersion(int value) : base(value)
    {
    }

    /// <summary>
    /// Version 2 — current DENM PDU protocol version
    /// </summary>
    public static readonly ProtocolVersion Value2 = new(2);

    public static ProtocolVersion FromValue(int value) => FromValueCore(value);
}
