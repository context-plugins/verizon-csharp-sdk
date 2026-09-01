using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Road Side Alert (RSA) message and its mandatory fields. This message is used to send alerts for nearby hazards to travelers. This message is defined in the SAE J2735 Standard. The system supports all mandatory fields, but only a subset of the optional fields.
/// </summary>
public record SaeAlertMessage
{
    /// <summary>
    /// Road Side Alert (RSA) message payload as defined in SAE J2735.
    /// </summary>
    [JsonPropertyName("saeAlert")]
    public required SaeAlertPayload SaeAlert { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
