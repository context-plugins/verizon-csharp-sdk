using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Firmware protocol. Valid values include: LWM2M, OMD-DM.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CampaignMetaInfoProtocol>))]
public sealed record CampaignMetaInfoProtocol : StringEnum<CampaignMetaInfoProtocol>
{
    private CampaignMetaInfoProtocol(string value) : base(value)
    {
    }

    public static readonly CampaignMetaInfoProtocol Lwm2M = new("LWM2M");

    public static readonly CampaignMetaInfoProtocol OmdDm = new("OMD-DM");

    public static CampaignMetaInfoProtocol FromValue(string value) => FromValueCore(value);
}
