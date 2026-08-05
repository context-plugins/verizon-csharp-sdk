using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record CredentialsRequest
{
    /// <summary>
    /// Enterprise Customer Profile ID
    /// </summary>
    [JsonPropertyName("ECPD")]
    public required string Ecpd { get; init; }

    /// <summary>
    /// Billing Account Number
    /// </summary>
    [JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// List of devices (1-50 items)
    /// </summary>
    [JsonPropertyName("items")]
    [MinLength(1)]
    [MaxLength(50)]
    public required IReadOnlyList<DeviceCredentialRequestItem> Items { get; init; }
}
