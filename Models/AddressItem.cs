using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Address details.
/// </summary>
public record AddressItem
{
    /// <summary>
    /// Street Address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("addressLine1")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9 ,]{3,32}$")]
    public string? AddressLine1 { get; init; }

    /// <summary>
    /// Optional address information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("addressLine2")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9 ,]{3,32}$")]
    public string? AddressLine2 { get; init; }

    /// <summary>
    /// Name of the city.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("city")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9 ]{3,32}$")]
    public string? City { get; init; }

    /// <summary>
    /// State code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    [StringLength(3, MinimumLength = 2)]
    [RegularExpression("^[A-Za-z]{2,3}$")]
    public string? State { get; init; }

    /// <summary>
    /// Country.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [StringLength(3, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z]{3,3}$")]
    public string? Country { get; init; }

    /// <summary>
    /// Five digit zipcode.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("zip")]
    [StringLength(5, MinimumLength = 5)]
    [RegularExpression("^[0-9]{5,5}$")]
    public string? Zip { get; init; }

    /// <summary>
    /// Four digit zip code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("zip4")]
    [StringLength(4, MinimumLength = 4)]
    [RegularExpression("^[0-9]{4,4}$")]
    public string? Zip4 { get; init; }
}
