using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DeviceCredentialRequestItem
{
    /// <summary>
    /// 15-digit alphanumeric identifier
    /// </summary>
    [JsonPropertyName("imei")]
    [RegularExpression("^[A-Za-z0-9]{15}$")]
    public required string Imei { get; init; }
}
