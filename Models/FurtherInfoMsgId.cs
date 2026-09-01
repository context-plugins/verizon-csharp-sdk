using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Message ID referencing a further information link (ATIS message).
/// </summary>
public record FurtherInfoMsgId
{
    /// <summary>
    /// Links to ATIS message. A link to any other incident information data that may be available in the normal ATIS incident description or other messages.
    /// <para>
    /// The value is described as a 4-character hexadecimal string.
    /// </para>
    /// </summary>
    [JsonPropertyName("furtherInfoID")]
    [RegularExpression("^[0-9A-Fa-f]{4}$")]
    public required string FurtherInfoId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
