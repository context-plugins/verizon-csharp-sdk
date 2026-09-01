using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// List of devices to removes.
/// </summary>
public record V1ListOfLicensesToRemoveRequest
{
    /// <summary>
    /// Set to 'append' to append the devices in the current request to the existing list. If there is no existing list then it will be created with only these devices. Leave this parameter out when you want to replace the existing list with the devices in the current request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// The IMEIs of the devices.
    /// </summary>
    [JsonPropertyName("deviceList")]
    public required IReadOnlyList<string> DeviceList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
