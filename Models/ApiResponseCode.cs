using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// ResponseCode and/or a message indicating success or failure of the request.
/// </summary>
public record ApiResponseCode
{
    /// <summary>
    /// Possible response codes.
    /// </summary>
    [JsonPropertyName("responseCode")]
    public required ResponseCode ResponseCode { get; init; }

    /// <summary>
    /// More details about the responseCode received.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
