using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// V2X messaging standard selection. Accepted values are 'sae' (SAE J2735) and 'etsi' (ETSI TS 103 301).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EtxmessageStandardEnum>))]
public sealed record EtxmessageStandardEnum : StringEnum<EtxmessageStandardEnum>
{
    private EtxmessageStandardEnum(string value) : base(value)
    {
    }

    public static readonly EtxmessageStandardEnum Etsi = new("etsi");

    public static readonly EtxmessageStandardEnum Sae = new("sae");

    public static EtxmessageStandardEnum FromValue(string value) => FromValueCore(value);
}
