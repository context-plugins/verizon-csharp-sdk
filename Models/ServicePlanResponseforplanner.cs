using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ServicePlanResponseforplanner
{
    /// <summary>
    /// The name of the service plan code
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierServicePlanCode")]
    public string? CarrierServicePlanCode { get; init; }

    /// <summary>
    /// The actiavtion code value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    /// <summary>
    /// key/value pairs assigned by the user for filtering.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extendedAttributes")]
    [MaxLength(5)]
    public IReadOnlyList<KvPairforplanner>? ExtendedAttributes { get; init; }

    /// <summary>
    /// The carrier name of the active profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// size in Kilobytes of the service plan
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sizeKb")]
    public int? SizeKb { get; init; }
}
