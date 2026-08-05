using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GbiactivateRequest5
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("servicePlan")]
    public string? ServicePlan { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceListWithServiceAddress")]
    public IReadOnlyList<DeviceListWithServiceAddress1>? DeviceListWithServiceAddress { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skuNumber")]
    public string? SkuNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("publicIpRestriction")]
    public string? PublicIpRestriction { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierName")]
    public string? CarrierName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mdnZipCode")]
    public string? MdnZipCode { get; init; }
}
