using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Information about the carrier.
/// </summary>
public record CarrierInformation
{
    /// <summary>
    /// The carrier that will perform the activation. This parameter is only required if you have more than one carrier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierName")]
    public string? CarrierName { get; init; }

    /// <summary>
    /// The service plan code that is assigned to the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("servicePlan")]
    public string? ServicePlan { get; init; }

    /// <summary>
    /// The device state. Valid values include: Activate, Suspend, Deactive, Pre-active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public string? State { get; init; }
}
