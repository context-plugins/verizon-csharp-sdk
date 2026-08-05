using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// Traveler Information Message (TIM) payload as defined in SAE J2735.
/// </summary>
public record SaeInfoPayload
{
    /// <summary>
    /// It is used to provide a sequence number within a stream of messages with the same DSRCmsgID (here RoadSideAlert) and from the same sender.
    /// </summary>
    [JsonPropertyName("msgCnt")]
    [Minimum(0)]
    [Maximum(127)]
    public int? MsgCnt { get; init; } = 0;

    /// <summary>
    /// The number of elapsed minutes of the current year in the time system being used (typically UTC time).
    /// -- the value 527040 shall be used for invalid
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeStamp")]
    [Minimum(0)]
    [Maximum(527040)]
    public int? TimeStamp { get; init; }

    /// <summary>
    /// Provides a relatively unique value which can be used to connect to (link to) other supporting messages in other formats.
    /// <para>
    /// The value is described as a 18-character hexadecimal string.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("packetID")]
    [RegularExpression("^[0-9A-Fa-f]{18}$")]
    public string? PacketId { get; init; }

    /// <summary>
    /// A valid internet style URI/URL in the form of a text string which will form the base of a compound string which, when
    /// combined with the URL-short data element, will link to the designated resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("urlB")]
    [StringLength(45, MinimumLength = 1)]
    public string? UrlB { get; init; }

    /// <summary>
    /// List of data frames.
    /// </summary>
    [JsonPropertyName("dataFrames")]
    [MinLength(1)]
    [MaxLength(8)]
    public required IReadOnlyList<DataFrame> DataFrames { get; init; }
}
