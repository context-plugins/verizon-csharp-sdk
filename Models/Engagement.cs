using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// The engagements associated with the account.
/// </summary>
public record Engagement
{
    /// <summary>
    /// The engagement ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("engagementId")]
    public string? EngagementId { get; init; }

    /// <summary>
    /// The charging group name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chargingGroup")]
    public string? ChargingGroup { get; init; }

    /// <summary>
    /// The services associated with the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("services")]
    public IReadOnlyList<AccountService>? Services { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
