using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Details of the service plan.
/// </summary>
public record ServicePlan
{
    /// <summary>
    /// The code that is used by the carrier for the service plan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierServicePlanCode")]
    public string? CarrierServicePlanCode { get; init; }

    /// <summary>
    /// The code of the service plan, which may not be the same as the name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    /// <summary>
    /// Any extended attributes for the service plan, as Key and Value pairs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extendedAttributes")]
    public IReadOnlyList<CustomFields>? ExtendedAttributes { get; init; }

    /// <summary>
    /// The name of the service plan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The size of the service plan in kilobytes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sizeKb")]
    public long? SizeKb { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
