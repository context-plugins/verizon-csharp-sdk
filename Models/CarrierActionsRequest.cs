using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Request for a carrier action.
/// </summary>
public record CarrierActionsRequest
{
    /// <summary>
    /// The name of a billing account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// Custom field names and values, if you want to only include devices that have matching values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customFields")]
    public IReadOnlyList<CustomFields>? CustomFields { get; init; }

    /// <summary>
    /// The devices for which you want to restore service, specified by device identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devices")]
    public IReadOnlyList<AccountDeviceList>? Devices { get; init; }

    /// <summary>
    /// set to "true" to suspend with billing, set to "false" to suspend without billing
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("withBilling")]
    public bool? WithBilling { get; init; }

    /// <summary>
    /// The name of a device group, if you want to restore service for all devices in that group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("groupName")]
    public string? GroupName { get; init; }

    /// <summary>
    /// The name of a service plan, if you want to only include devices that have that service plan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("servicePlan")]
    public string? ServicePlan { get; init; }
}
