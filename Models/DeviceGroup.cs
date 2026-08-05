using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Returns a list of all device groups in a specified account.
/// </summary>
public record DeviceGroup
{
    /// <summary>
    /// The description of the device group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Any extended attributes for the device group, as Key and Value pairs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extendedAttributes")]
    public IReadOnlyList<CustomFields>? ExtendedAttributes { get; init; }

    /// <summary>
    /// Identifies the default device group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isDefaultGroup")]
    public bool? IsDefaultGroup { get; init; }

    /// <summary>
    /// The name of the device group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
