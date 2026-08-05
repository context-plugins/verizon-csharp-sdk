using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Search by device id.
/// </summary>
public record DeviceIdSearch
{
    /// <summary>
    /// The string appears anywhere in the identifer.
    /// </summary>
    [JsonPropertyName("contains")]
    public required string Contains { get; init; }

    /// <summary>
    /// The identifer must start with the specified string.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startswith")]
    public string? Startswith { get; init; }

    /// <summary>
    /// The identifier must end with the specified string.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endswith")]
    public string? Endswith { get; init; }

    /// <summary>
    /// The type of the device identifier. Valid types of identifiers are:ESN (decimal),EID,ICCID (up to 20 digits),IMEI (up to 16 digits),MDN,MEID (hexadecimal),MSISDN.
    /// </summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; init; }
}
