using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Core.Validation.Attributes;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// This represent the management container describing the meta information about the event, such as the detection time, the event's location, the source of the event, and the notification distance.
/// </summary>
public record Management
{
    [JsonPropertyName("actionId")]
    public required ActionId ActionId { get; init; }

    /// <summary>
    /// Timestamp in milliseconds since start of 2004 when event was first generated
    /// </summary>
    [JsonPropertyName("detectionTime")]
    [Minimum(0)]
    [Maximum(4398046511103)]
    public required long DetectionTime { get; init; }

    /// <summary>
    /// Timestamp in milliseconds since start of 2004 when the DENM message was generated.
    /// </summary>
    [JsonPropertyName("referenceTime")]
    [Minimum(0)]
    [Maximum(4398046511103)]
    public required long ReferenceTime { get; init; }

    [JsonPropertyName("eventPosition")]
    public required EventPosition EventPosition { get; init; }

    /// <summary>
    /// Specifies how far the event is relevant to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("awarenessDistance")]
    public AwarenessDistance? AwarenessDistance { get; init; }

    /// <summary>
    /// The type of ITS station that generated the DENM. The value shall be set to:
    /// - 0 <c>unknown</c>          - information about the ITS-S context is not provided,
    /// - 1 <c>pedestrian</c>       - ITS-S carried by human being not using a mechanical device for their trip (VRU profile 1),
    /// - 2 <c>cyclist</c>          - ITS-S mounted on non-motorized unicycles, bicycles , tricycles, quadracycles (VRU profile 2),
    /// - 3 <c>moped</c>            - ITS-S mounted on light motor vehicles with less than four wheels as defined in UNECE/TRANS/WP.29/78/Rev.4 [16]
    ///                             class L1, L2 (VRU Profile 3),
    /// - 4 <c>motorcycles</c>      - ITS-S mounted on motor vehicles with less than four wheels as defined in UNECE/TRANS/WP.29/78/Rev.4 [16]
    ///                             class L3, L4, L5, L6, L7 (VRU Profile 3),
    /// - 5 <c>passengerCar</c>     - ITS-S mounted on small passenger vehicles as defined in UNECE/TRANS/WP.29/78/Rev.4 [16] class M1,
    /// - 6 <c>bus</c>              - ITS-S mounted on large passenger vehicles as defined in UNECE/TRANS/WP.29/78/Rev.4 [16] class M2, M3,
    /// - 7 <c>lightTruck</c>       - ITS-S mounted on light Goods Vehicles as defined in UNECE/TRANS/WP.29/78/Rev.4 [16] class N1,
    /// - 8 <c>heavyTruck</c>       - ITS-S mounted on Heavy Goods Vehicles as defined in UNECE/TRANS/WP.29/78/Rev.4 [16] class N2 and N3,
    /// - 9 <c>trailer</c>          - ITS-S mounted on an unpowered vehicle that is intended to be towed by a powered vehicle as defined in
    ///                             UNECE/TRANS/WP.29/78/Rev.4 [16] class O,
    /// - 10 <c>specialVehicles</c> - ITS-S mounted on vehicles which have special purposes other than the above (e.g. moving road works vehicle),
    /// - 11 <c>tram</c>            - ITS-S mounted on a vehicle which runs on tracks along public streets,
    /// - 12 <c>lightVruVehicle</c> - ITS-S carried by a human being traveling on light vehicle , incl. possible use of roller skates or skateboards (VRU profile 2),
    /// - 13 <c>animal</c>          - ITS-S carried by an animal presenting a safety risk to other road users e.g. domesticated dog in a city or horse (VRU Profile 4),
    /// - 14                   - reserved for future usage,
    /// - 15 <c>roadSideUnit</c>    - ITS-S mounted on an infrastructure typically positioned outside of the drivable roadway (e.g. on a gantry, on a pole,
    ///                             on a stationary road works trailer); the infrastructure is static during the entire operation period of the ITS-S (e.g. no stop and go activity),
    /// - 16-255               - are reserved for future usage.
    /// </summary>
    [JsonPropertyName("stationType")]
    [Minimum(0)]
    [Maximum(255)]
    public required int StationType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
