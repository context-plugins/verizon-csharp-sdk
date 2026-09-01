using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

public record DeviceCredentialRequestItem
{
    /// <summary>
    /// 15-digit alphanumeric identifier
    /// </summary>
    [JsonPropertyName("imei")]
    [RegularExpression("^[A-Za-z0-9]{15}$")]
    public required string Imei { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
