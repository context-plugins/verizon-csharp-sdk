using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record Fields1
{
    /// <summary>
    /// List of device sensors and their most recently reported values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item")]
    public SearchDeviceByPropertyFields? Item { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
