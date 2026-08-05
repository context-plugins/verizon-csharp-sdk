using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// All error messages are returned in this format. Error codes and messages are listed on the Error Codes page, along with explanations and suggestions for corrective actions.
/// </summary>
public record DeviceDiagnosticsResultError
{
    /// <summary>
    /// Simple error code.
    /// </summary>
    [JsonPropertyName("errorCode")]
    public required string ErrorCode { get; init; }

    /// <summary>
    /// Detailed error message.
    /// </summary>
    [JsonPropertyName("errorMessage")]
    public required string ErrorMessage { get; init; }
}
