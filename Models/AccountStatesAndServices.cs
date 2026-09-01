using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Returns a list and details of all custom services and states defined for a specified account.
/// </summary>
public record AccountStatesAndServices
{
    /// <summary>
    /// The engagements associated with the account.
    /// </summary>
    [JsonPropertyName("engagement")]
    public required IReadOnlyList<Engagement> Engagement { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
