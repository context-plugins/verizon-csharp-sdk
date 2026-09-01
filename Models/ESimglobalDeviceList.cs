using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record ESimGlobalDeviceList
{
    /// <summary>
    /// The numeric name of the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// The last status of the device as a list filter.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("provisioningStatusFilter")]
    public ProvisioningStatusFilter? ProvisioningStatusFilter { get; init; }

    /// <summary>
    /// The last status of the device's profile as a filter.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profileStatusFilter")]
    public ProfileStatusFilter? ProfileStatusFilter { get; init; }

    /// <summary>
    /// The cellular service provider.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierNameFilter")]
    public string? CarrierNameFilter { get; init; }

    /// <summary>
    /// An array of device identifiers to filter the list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceFilter")]
    public IReadOnlyList<DeviceFilter>? DeviceFilter { get; init; }
}
