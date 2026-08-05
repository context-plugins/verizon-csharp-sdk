using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record CreateTargetRequestFields
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("httpheaders")]
    public FieldsHttpHeaders? Httpheaders { get; init; }

    /// <summary>
    /// List of device types.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devicetypes")]
    public IReadOnlyList<string>? Devicetypes { get; init; }
}
