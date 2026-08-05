using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Various types of information about the device, grouped into categories. Each category object contains the category name and a list of Extended Attribute objects as key-value pairs.
/// </summary>
public record DiagnosticsCategory
{
    /// <summary>
    /// The name of the category.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("categoryName")]
    public string? CategoryName { get; init; }

    /// <summary>
    /// A list of Extended Attribute objects as key-value pairs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extendedAttributes")]
    public IReadOnlyList<CustomFields>? ExtendedAttributes { get; init; }
}
