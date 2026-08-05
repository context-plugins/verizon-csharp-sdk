using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Current status of the campaign.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CampaignStatus>))]
public sealed record CampaignStatus : StringEnum<CampaignStatus>
{
    private CampaignStatus(string value) : base(value)
    {
    }

    public static readonly CampaignStatus CampaignRequestPending = new("CampaignRequestPending");

    public static readonly CampaignStatus CampaignRequestFailed = new("CampaignRequestFailed");

    public static readonly CampaignStatus CampaignRequestQueued = new("CampaignRequestQueued");

    public static readonly CampaignStatus CampaignCancelled = new("CampaignCancelled");

    public static readonly CampaignStatus CampaignAborted = new("CampaignAborted");

    public static readonly CampaignStatus CampaignFailed = new("CampaignFailed");

    public static readonly CampaignStatus CampaignScheduled = new("CampaignScheduled");

    public static readonly CampaignStatus CampaignEnded = new("CampaignEnded");

    public static CampaignStatus FromValue(string value) => FromValueCore(value);
}
