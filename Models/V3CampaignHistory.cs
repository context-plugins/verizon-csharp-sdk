using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Campaign history.
/// </summary>
public record V3CampaignHistory
{
    /// <summary>
    /// Has more report flag?
    /// </summary>
    [JsonPropertyName("hasMoreData")]
    public required bool HasMoreData { get; init; }

    /// <summary>
    /// Campaign identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastSeenCampaignId")]
    public string? LastSeenCampaignId { get; init; }

    /// <summary>
    /// Firmware upgrade list.
    /// </summary>
    [JsonPropertyName("campaignList")]
    public required IReadOnlyList<V3CampaignMetaInfo?> CampaignList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
