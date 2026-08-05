using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record Rateplantype2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sizeKb")]
    public string? SizeKb { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierRatePlanCode")]
    public string? CarrierRatePlanCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("zeroDollarBilling")]
    public bool? ZeroDollarBilling { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("promotionOffered")]
    public bool? PromotionOffered { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("promotionDays")]
    public int? PromotionDays { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ratePlanType")]
    public string? RatePlanType { get; init; }

    /// <summary>
    /// Account information
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account")]
    public IReadOnlyList<Accountid>? Account { get; init; }
}
