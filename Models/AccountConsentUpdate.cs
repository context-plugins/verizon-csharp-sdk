using System.Text.Json.Serialization;

namespace Verizon.Models;

public record AccountConsentUpdate
{
    /// <summary>
    /// The numeric name of the account, including leading zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// The consent setting to use for all the devices in the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allDeviceConsent")]
    public int? AllDeviceConsent { get; init; }
}
