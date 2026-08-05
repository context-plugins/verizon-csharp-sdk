using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Request to deactivate a carrier.
/// </summary>
public record CarrierDeactivateRequest
{
    /// <summary>
    /// The name of a billing account.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// The devices for which you want to deactivate service, specified by device identifier.
    /// </summary>
    [JsonPropertyName("devices")]
    public required IReadOnlyList<AccountDeviceList> Devices { get; init; }

    /// <summary>
    /// Code identifying the reason for the deactivation. Currently the only valid reason code is “FF”, which corresponds to General Admin/Maintenance.
    /// </summary>
    [JsonPropertyName("reasonCode")]
    public required string ReasonCode { get; init; }

    /// <summary>
    /// Custom field names and values, if you want to only include devices that have matching values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customFields")]
    public IReadOnlyList<CustomFields>? CustomFields { get; init; }

    /// <summary>
    /// Fees may be assessed for deactivating Verizon Wireless devices, depending on the account contract. The etfWaiver parameter waives the Early Termination Fee (ETF), if applicable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("etfWaiver")]
    public bool? EtfWaiver { get; init; }

    /// <summary>
    /// The name of a device group, if you want to deactivate all devices in that group.
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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deleteAfterDeactivation")]
    public bool? DeleteAfterDeactivation { get; init; }
}
