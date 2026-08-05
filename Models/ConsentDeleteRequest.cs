using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ConsentDeleteRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// Device ID list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceList")]
    public IReadOnlyList<string>? DeviceList { get; init; }
}
