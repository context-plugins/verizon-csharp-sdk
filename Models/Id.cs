using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Id
{
    /// <summary>
    /// The value of the device identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? IdValue { get; init; }

    /// <summary>
    /// The type of the device identifier. Valid types of identifiers are:ESN (decimal),EID,ICCID (up to 20 digits),IMEI (up to 16 digits),MDN,MEID (hexadecimal),MSISDN.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("kind")]
    public string? Kind { get; init; }
}
