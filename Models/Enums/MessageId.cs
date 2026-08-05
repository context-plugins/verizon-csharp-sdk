using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The type of ITIS message (typically 1 for DENM).
/// </summary>
[JsonConverter(typeof(IntEnumConverter<MessageId>))]
public sealed record MessageId : IntEnum<MessageId>
{
    private MessageId(int value) : base(value)
    {
    }

    /// <summary>
    /// Value 1 — identifies the message as a DENM
    /// </summary>
    public static readonly MessageId Value1 = new(1);

    public static MessageId FromValue(int value) => FromValueCore(value);
}
