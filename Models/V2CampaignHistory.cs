using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Campaign history details.
/// </summary>
public record V2CampaignHistory
{
    /// <summary>
    /// Has more report flag.
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
    /// Software upgrade list.
    /// </summary>
    [JsonPropertyName("campaignList")]
    public required IReadOnlyList<V2CampaignMetaInfo?> CampaignList { get; init; }
}
