using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record RequestTrigger
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerId")]
    public string? TriggerId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerName")]
    public string? TriggerName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("organizationName")]
    public string? OrganizationName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggerCategory")]
    public string? TriggerCategory { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("promoAlerts")]
    public IReadOnlyList<PromoAlert1>? PromoAlerts { get; init; }
}
