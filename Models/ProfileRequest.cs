using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ProfileRequest
{
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    [JsonPropertyName("devices")]
    [MaxLength(100)]
    public required IReadOnlyList<DeviceList> Devices { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierName")]
    public string? CarrierName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("servicePlan")]
    public string? ServicePlan { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mdnZipCode")]
    public string? MdnZipCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primaryPlaceOfUse")]
    [MaxLength(25)]
    public IReadOnlyList<PrimaryPlaceOfUse>? PrimaryPlaceOfUse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smsrOid")]
    [StringLength(46, MinimumLength = 3)]
    [RegularExpression("^[0-9.]{3,46}$")]
    public string? SmsrOid { get; init; }

    /// <summary>
    /// The name of the pool of IP addresses assigned to the profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierIpPoolName")]
    public string? CarrierIpPoolName { get; init; }
}
