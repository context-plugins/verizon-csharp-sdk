using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GioProfileRequest
{
    [JsonPropertyName("devices")]
    [MaxLength(100)]
    public required IReadOnlyList<GioDeviceList> Devices { get; init; }

    [JsonPropertyName("accountName")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[0-9\\-]{3,32}$")]
    public required string AccountName { get; init; }

    /// <summary>
    /// The Subscription Manager Secure Router Object ID, used for remote SIM provisioning. SMSR securely routes the download and management of eSIM profiles.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smrsOid")]
    public string? SmrsOid { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mdnZipCode")]
    [StringLength(5, MinimumLength = 5)]
    [RegularExpression("^[0-9]{5,5}$")]
    public string? MdnZipCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("servicePlan")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9 ]{3,32}$")]
    public string? ServicePlan { get; init; }
}
