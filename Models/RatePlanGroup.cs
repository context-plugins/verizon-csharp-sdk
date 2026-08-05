using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record RatePlanGroup
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ratePlanGroupDescription")]
    public string? RatePlanGroupDescription { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ratePlanType")]
    public object? RatePlanType { get; init; }

    /// <summary>
    /// An array of rateplan names
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ratePlan")]
    public IReadOnlyList<Rateplantype2>? RatePlan { get; init; }

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

    /// <summary>
    /// Account information
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account")]
    public IReadOnlyList<Accountid>? Account { get; init; }
}
