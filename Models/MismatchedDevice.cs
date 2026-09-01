using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// 4G devices with an ICCID (SIM) that was not activated with the expected IMEI (hardware) during a specified time frame.
/// </summary>
public record MismatchedDevice
{
    /// <summary>
    /// The account that the device is associated with.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// The assigned phone number of the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mdn")]
    public string? Mdn { get; init; }

    /// <summary>
    /// The date and time when the SIM was last activated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("activationDate")]
    public string? ActivationDate { get; init; }

    /// <summary>
    /// The ID of the SIM.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iccid")]
    public string? Iccid { get; init; }

    /// <summary>
    /// The IMEI of the device prior to the SIM OTA activation on simOtaDate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("preImei")]
    public string? PreImei { get; init; }

    /// <summary>
    /// The IMEI of the device after the SIM OTA activation on simOtaDate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postImei")]
    public string? PostImei { get; init; }

    /// <summary>
    /// The date and time of the SIM OTA activation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("simOtaDate")]
    public string? SimOtaDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
