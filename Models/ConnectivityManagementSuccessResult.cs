using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Response to successful request.
/// </summary>
public record ConnectivityManagementSuccessResult
{
    /// <summary>
    /// A value of “true” indicates that the device group was created successfully.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("success")]
    public bool? Success { get; init; }
}
