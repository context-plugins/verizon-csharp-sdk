using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record ManagedAccountsAddRequest
{
    /// <summary>
    /// Account identifier
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

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
    /// managed account list
    /// </summary>
    [JsonPropertyName("managedAccList")]
    public required IReadOnlyList<string> ManagedAccList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
