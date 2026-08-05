using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Whether the device location request was successful or not.
/// </summary>
public record DeviceLocationSuccessResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("success")]
    public bool? Success { get; init; }
}
