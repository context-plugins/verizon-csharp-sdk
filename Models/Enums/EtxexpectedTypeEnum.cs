using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The format of the payload in the response body.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EtxexpectedTypeEnum>))]
public sealed record EtxexpectedTypeEnum : StringEnum<EtxexpectedTypeEnum>
{
    private EtxexpectedTypeEnum(string value) : base(value)
    {
    }

    public static readonly EtxexpectedTypeEnum Base64 = new("BASE64");

    public static readonly EtxexpectedTypeEnum Json = new("JSON");

    public static EtxexpectedTypeEnum FromValue(string value) => FromValueCore(value);
}
