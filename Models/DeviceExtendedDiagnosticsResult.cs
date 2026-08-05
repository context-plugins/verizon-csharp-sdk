using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Result for a request to obtain device extended diagnostics.
/// </summary>
public record DeviceExtendedDiagnosticsResult
{
    /// <summary>
    /// The response includes various types of information about the device, grouped into categories. Each category object contains the category name and a list of Extended Attribute objects as key-value pairs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("categories")]
    public IReadOnlyList<DiagnosticsCategory>? Categories { get; init; }
}
