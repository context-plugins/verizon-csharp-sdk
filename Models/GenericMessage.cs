using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// A message carrying a generic (custom) V2X payload.
/// </summary>
public record GenericMessage
{
    /// <summary>
    /// Custom message which is defined by the user and can support "any" message type or format.
    /// <para>
    /// <b>Note:</b> ETX prefers the j2735 or the j2735_gr encoding and only vendor specific message types are allowed to be published in different message formats.
    /// </para>
    /// </summary>
    [JsonPropertyName("generic")]
    public required GenericPayload Generic { get; init; }
}
