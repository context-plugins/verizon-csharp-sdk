using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Id of the devices.
/// </summary>
public record LicenseDeviceId
{
    /// <summary>
    /// For 4G devices, IMEI (decimal, up to 15 digits) for unassign and ICCID (decimal, up to 20 digits) for assign.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[0-9]{3,32}$")]
    public string? Id { get; init; }

    /// <summary>
    /// For 4G devices, ICCID (decimal, up to 20 digits) for unassign and IMEI (decimal, up to 15 digits) for assign.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("kind")]
    [StringLength(6, MinimumLength = 3)]
    [RegularExpression("^[A-Z]{3,6}$")]
    public string? Kind { get; init; }
}
