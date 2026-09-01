using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// A success response includes an array of all matching devices.
/// </summary>
public record SearchDeviceByPropertyResponseList
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DeviceProperty")]
    [MaxLength(100)]
    public IReadOnlyList<SearchDeviceByPropertyResponse>? DeviceProperty { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
