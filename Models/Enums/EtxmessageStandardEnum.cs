using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// V2X messaging standard selection. Accepted values are 'sae' (SAE J2735) and 'etsi' (ETSI TS 103 301).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EtxMessageStandardEnum>))]
public sealed record EtxMessageStandardEnum : StringEnum<EtxMessageStandardEnum>
{
    private EtxMessageStandardEnum(string value) : base(value)
    {
    }

    public static readonly EtxMessageStandardEnum Etsi = new("etsi");

    public static readonly EtxMessageStandardEnum Sae = new("sae");

    public static EtxMessageStandardEnum FromValue(string value) => FromValueCore(value);
}
