using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record ManagedAccountCancelRequest
{
    /// <summary>
    /// Managed account identifier
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// Primary Account identifier
    /// </summary>
    [JsonPropertyName("paccountName")]
    public required string PaccountName { get; init; }

    /// <summary>
    /// Service name
    /// </summary>
    [JsonPropertyName("serviceName")]
    public ServiceName ServiceName { get; init; } = ServiceName.Location;

    /// <summary>
    /// SKU name
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>
    /// Transaction identifier returned by provision request
    /// </summary>
    [JsonPropertyName("txid")]
    public required string Txid { get; init; }
}
