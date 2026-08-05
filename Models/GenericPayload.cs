using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Custom message which is defined by the user and can support "any" message type or format.
/// <para>
/// <b>Note:</b> ETX prefers the j2735 or the j2735_gr encoding and only vendor specific message types are allowed to be published in different message formats.
/// </para>
/// </summary>
public record GenericPayload
{
    /// <summary>
    /// The type of message. This can be any of the standard V2X messages specified in the SAE J2735 standard (e.g. BSM, PSM, RSA, TIM, MAP, SPAT, etc.), or it can be a vendor specific message type that is not defined by the standard.
    /// </summary>
    [JsonPropertyName("messageType")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[a-zA-Z0-9~\\+\\-!@#$%^&*()\\`\\[\\]{=};\"':,.\\/<>?|\\s]+$")]
    public required string MessageType { get; init; }

    /// <summary>
    /// The encoding of the message (e.g. j2735, protobuf, json, Avro, etc.). If the message is encapsulated within a GeoRoutedMsg protocol buffer wrapper, append _gr to the message format (e.g. j2735 =&gt; j2735_gr).
    /// <para>
    /// <b>Note:</b> ETX prefers the j2735 or the j2735_gr encoding and only vendor specific message types are allowed to be published in different message formats.
    /// </para>
    /// </summary>
    [JsonPropertyName("messageFormat")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[a-zA-Z0-9~\\+\\-!@#$%^&*()\\`\\[\\]{=};\"':,.\\/<>?|\\s]+$")]
    public required string MessageFormat { get; init; }

    /// <summary>
    /// The base64 encoded message.
    /// </summary>
    [JsonPropertyName("payload")]
    [StringLength(8192, MinimumLength = 4)]
    [RegularExpression("^(?:[a-zA-Z0-9+\\/]{4})*(?:|(?:[a-zA-Z0-9+\\/]{3}=)|(?:[a-zA-Z0-9+\\/]{2}==)|(?:[a-zA-Z0-9+\\/]{1}===))$")]
    public required string Payload { get; init; }
}
