using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record ManagedAccountCancelResponse
{
    /// <summary>
    /// Transaction identifier
    /// </summary>
    [JsonPropertyName("txid")]
    public required string Txid { get; init; }

    /// <summary>
    /// Managed account identifier
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// Primary account identifier
    /// </summary>
    [JsonPropertyName("paccountName")]
    public required string PaccountName { get; init; }

    /// <summary>
    /// Service name
    /// </summary>
    [JsonPropertyName("serviceName")]
    public ServiceName ServiceName { get; init; } = ServiceName.Location;

    /// <summary>
    /// Deactivate/cancel status, Success or Fail
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    /// <summary>
    /// Detailed reason
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
