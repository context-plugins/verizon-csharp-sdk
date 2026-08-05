using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Service associated with the account.
/// </summary>
public record AccountService
{
    /// <summary>
    /// The name of the service plan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The description of the service plan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The state of the service plan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("states")]
    public IReadOnlyList<State>? States { get; init; }
}
