using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

public record DtoFilter
{
    /// <summary>
    /// Use to provide device details for alerts specific to a device
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("$expand")]
    public string? Expand { get; init; }

    /// <summary>
    /// Limit the number of results returned
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("$limitnumber")]
    [Minimum(0)]
    [Maximum(100)]
    public int? Limitnumber { get; init; }

    /// <summary>
    /// A flag set to show if pagination requested (false) or not (true)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("$nopagination")]
    public bool? Nopagination { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("$page")]
    public string? Page { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("$pagenumber")]
    [Minimum(0)]
    [Maximum(100)]
    public int? Pagenumber { get; init; }

    /// <summary>
    /// Limits the fields of the device that the user is interested in rather than all of the fields
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("$projection")]
    [MaxLength(100)]
    public IReadOnlyList<string>? Projection { get; init; }

    /// <summary>
    /// Filters results based on user defined criteria
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("$selection")]
    public IReadOnlyDictionary<string, object>? Selection { get; init; }
}
