using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// Error response.
/// </summary>
public record HyperPreciseLocationResultError
{
    /// <summary>
    /// Error Code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responseCode")]
    public ErrorResponseCode? ResponseCode { get; init; }

    /// <summary>
    /// Error message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    /// <summary>
    /// Fault occurred while responding.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fault")]
    public HyperPreciseLocationFault? Fault { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
