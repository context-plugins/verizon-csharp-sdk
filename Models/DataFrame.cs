using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;
using Verizon.Models.AnyOf;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// The data frame allows sending various advisory and road sign types of information to equipped devices.
/// </summary>
public record DataFrame
{
    /// <summary>
    /// Always set to 0 and carries no meaning. Legacy field maintained for backward compatibility.
    /// </summary>
    [JsonPropertyName("doNotUse1")]
    [Minimum(0)]
    [Maximum(31)]
    public int? DoNotUse1 { get; init; } = 0;

    /// <summary>
    /// The frameType data element provides the type of message to follow in the rest of the message frame structure. The following frame types are supported:
    ///  - unknown
    ///  - advisory
    ///  - roadSignage
    ///  - commercialSignage
    /// </summary>
    [JsonPropertyName("frameType")]
    public required FrameType FrameType { get; init; }

    [JsonPropertyName("msgId")]
    public required MsgId MsgId { get; init; }

    /// <summary>
    /// The V2X year consists of integer values from zero to 4095 representing the year according to the Gregorian calendar date system. The value of zero shall represent an unknown value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startYear")]
    [Minimum(0)]
    [Maximum(4095)]
    public int? StartYear { get; init; }

    /// <summary>
    /// Start time expresses the number of elapsed minutes of the current year in the time system being used (typically UTC time). The value 527040 shall be used for invalid.
    /// </summary>
    [JsonPropertyName("startTime")]
    [Minimum(0)]
    [Maximum(527040)]
    public required int StartTime { get; init; }

    /// <summary>
    /// The duration, in units of whole minutes, that a object persists for. A value of 32000 means that the object persists forever. The range 0..32000 provides for about 22.2 days of maximum duration.
    /// </summary>
    [JsonPropertyName("durationTime")]
    [Minimum(0)]
    [Maximum(32000)]
    public required int DurationTime { get; init; }

    /// <summary>
    /// The relative importance of the sign, on a scale from zero (least important) to seven (most important).
    /// </summary>
    [JsonPropertyName("priority")]
    [Minimum(0)]
    [Maximum(7)]
    public required int Priority { get; init; }

    /// <summary>
    /// Always set to 0 and carries no meaning. Legacy field maintained for backward compatibility.
    /// </summary>
    [JsonPropertyName("doNotUse2")]
    [Minimum(0)]
    [Maximum(31)]
    public int? DoNotUse2 { get; init; } = 0;

    /// <summary>
    /// The data frame is used to support the cross-cutting need in many V2X messages to describe arbitrary spatial areas (polygons, boundary lines, and other basic shapes) required by various message types in a small message size. This data frame can describe a complex path or region of arbitrary size using either one of the two supported node offset methods (XY offsets or LL offsets) or using simple geometric projections.
    /// </summary>
    [JsonPropertyName("regions")]
    [MinLength(1)]
    [MaxLength(16)]
    public required IReadOnlyList<GeographicalPath> Regions { get; init; }

    /// <summary>
    /// Always set to 0 and carries no meaning. Legacy field maintained for backward compatibility.
    /// </summary>
    [JsonPropertyName("doNotUse3")]
    [Minimum(0)]
    [Maximum(31)]
    public int? DoNotUse3 { get; init; } = 0;

    /// <summary>
    /// Always set to 0 and carries no meaning. Legacy field maintained for backward compatibility.
    /// </summary>
    [JsonPropertyName("doNotUse4")]
    [Minimum(0)]
    [Maximum(31)]
    public int? DoNotUse4 { get; init; } = 0;

    [JsonPropertyName("content")]
    public required Content Content { get; init; }

    /// <summary>
    /// It contains information that extends the original traveler data
    /// frame to enable addition of future entities. Friction information is the first entity included in the new part three content.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contentNew")]
    public ContentNew? ContentNew { get; init; }
}
