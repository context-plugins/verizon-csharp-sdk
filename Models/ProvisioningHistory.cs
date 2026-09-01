using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// The provisioning history of a specified device during a specified time period.
/// </summary>
public record ProvisioningHistory
{
    /// <summary>
    /// The date and time when the provisioning event occured.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("occurredAt")]
    public string? OccurredAt { get; init; }

    /// <summary>
    /// The success or failure of the provisioning event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// The user who performed the provisioning event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eventBy")]
    public string? EventBy { get; init; }

    /// <summary>
    /// The provisioning action:Activate,Suspend,Restore,Deactivate,Device Move.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eventType")]
    public string? EventType { get; init; }

    /// <summary>
    /// The MDN assigned to the device after the provisioning event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mdn")]
    public string? Mdn { get; init; }

    /// <summary>
    /// The MSISDN assigned to the device after the provisioning event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("msisdn")]
    public string? Msisdn { get; init; }

    /// <summary>
    /// The service plan of the device after the provisioning event occurred.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("servicePlan")]
    public string? ServicePlan { get; init; }

    /// <summary>
    /// Any extended attributes for the event, as Key and Value pairs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extendedAttributes")]
    public IReadOnlyList<CustomFields>? ExtendedAttributes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
