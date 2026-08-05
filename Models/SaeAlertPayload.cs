using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// Road Side Alert (RSA) message payload as defined in SAE J2735.
/// </summary>
public record SaeAlertPayload
{
    /// <summary>
    /// It is used to provide a sequence number within a stream of messages with the same DSRCmsgID (here RoadSideAlert) and from the same sender.
    /// </summary>
    [JsonPropertyName("msgCnt")]
    [Minimum(0)]
    [Maximum(127)]
    public int? MsgCnt { get; init; } = 0;

    /// <summary>
    /// The ITIS Code that describes the alert/danger/hazard. All ITS standards use the same types here to explain the type of the alert/danger/hazard involved.
    /// <para>
    /// The complete set of ITIS codes can be found in Volume Two of the SAE J2540 standard. This is a set of over 1000 items which are used to encode common events and list items in ITS.
    /// </para>
    /// </summary>
    [JsonPropertyName("typeEvent")]
    [Minimum(0)]
    [Maximum(65535)]
    public required int TypeEvent { get; init; }

    /// <summary>
    /// ITIS code set entries to further describe the event, give advice, or any other ITIS codes related to the event/danger/hazard.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MinLength(1)]
    [MaxLength(8)]
    public IReadOnlyList<int>? Description { get; init; }
}
