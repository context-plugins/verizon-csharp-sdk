using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The format of the payload in the response body.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EtxExpectedTypeEnum>))]
public sealed record EtxExpectedTypeEnum : StringEnum<EtxExpectedTypeEnum>
{
    private EtxExpectedTypeEnum(string value) : base(value)
    {
    }

    public static readonly EtxExpectedTypeEnum Base64 = new("BASE64");

    public static readonly EtxExpectedTypeEnum Json = new("JSON");

    public static EtxExpectedTypeEnum FromValue(string value) => FromValueCore(value);
}
