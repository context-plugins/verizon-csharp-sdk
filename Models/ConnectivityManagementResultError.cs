using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Response to errors.
/// </summary>
public record ConnectivityManagementResultError
{
    /// <summary>
    /// Code of the error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; init; }

    /// <summary>
    /// Details of the error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; init; }
}
