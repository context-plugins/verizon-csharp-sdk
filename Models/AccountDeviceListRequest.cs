using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// Request for listing account devices.
/// </summary>
public record AccountDeviceListRequest
{
    /// <summary>
    /// The billing account for which a list of devices is returned. If you don't specify an accountName, the list includes all devices to which you have access.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// An identifier for a single device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceId")]
    public DeviceId? DeviceId { get; init; }

    /// <summary>
    /// Filter for a list of devices.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public AccountDeviceListFilter? Filter { get; init; }

    /// <summary>
    /// The name of a device state, to only include devices in that state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currentState")]
    public string? CurrentState { get; init; }

    /// <summary>
    /// Custom field names and values, if you want to only include devices that have matching values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customFields")]
    public IReadOnlyList<CustomFields>? CustomFields { get; init; }

    /// <summary>
    /// Only include devices that were added after this date and time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("earliest")]
    public string? Earliest { get; init; }

    /// <summary>
    /// Only include devices that are in this device group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("groupName")]
    public string? GroupName { get; init; }

    /// <summary>
    /// Only include devices that were added before this date and time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("latest")]
    public string? Latest { get; init; }

    /// <summary>
    /// Only include devices that have this service plan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("servicePlan")]
    public string? ServicePlan { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxNumberOfDevices")]
    [Minimum(0)]
    [Maximum(500)]
    public int? MaxNumberOfDevices { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("largestDeviceIdSeen")]
    [Minimum(0)]
    [Maximum(0)]
    public long? LargestDeviceIdSeen { get; init; }
}
