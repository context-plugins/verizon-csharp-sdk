using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// A successful response returns an array of lead objects.
/// </summary>
public record AccountLead
{
    /// <summary>
    /// The customer address for the line's primary place of use, for line usage taxation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public Address? Address { get; init; }

    /// <summary>
    /// Unique number for each lead. Use this value in the leadId parameter when activating devices to credit the activations to the lead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("leadId")]
    public string? LeadId { get; init; }

    /// <summary>
    /// The current state of the lead, such as “Qualified” or “Closed.”
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("leadState")]
    public string? LeadState { get; init; }
}
