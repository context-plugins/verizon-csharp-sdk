using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Lookup object for identifying an ETX client. One of the following IDs is required: DeviceID, IMEI, ICCID, or IMSI. If more than one ID is provided, the API will use the first ID found in the following order: DeviceID, IMEI, ICCID, IMSI.
/// </summary>
public record EtxClientIdLookup
{
    /// <summary>
    /// The generated ID (UUID v4) for the device. It can be used as:
    ///   - the MQTT Client ID when connecting to the Message Exchange system
    ///   - a parameter when asking for the connection endpoint
    ///   - a parameter when finishing the device registration
    ///   - a parameter when unregistering the device
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DeviceID")]
    public Guid? DeviceId { get; init; }

    /// <summary>
    /// The IMEI number of the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("IMEI")]
    [MaxLength(19)]
    [RegularExpression("^(\\d{2}-\\d{6}-\\d{6}-\\d{1,2})$|^(\\d{15,16})$")]
    public string? Imei { get; init; }

    /// <summary>
    /// The ICCID number of the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ICCID")]
    [StringLength(20, MinimumLength = 19)]
    [RegularExpression("^(89\\d{17,18})$")]
    public string? Iccid { get; init; }

    /// <summary>
    /// The IMSI number of the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("IMSI")]
    [StringLength(15, MinimumLength = 14)]
    [RegularExpression("^\\d{14,15}$")]
    public string? Imsi { get; init; }
}
