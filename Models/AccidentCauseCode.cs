using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

/// <summary>
/// Cause code wrapper for accident events.
/// </summary>
public record AccidentCauseCode
{
    /// <summary>
    /// The value shall be set to:
    /// - 0 <c>unavailable</c>                        - in case the information on the sub cause of the accident is unavailable,
    /// - 1 <c>multiVehicleAccident</c>               - in case more than two vehicles are involved in accident,
    /// - 2 <c>heavyAccident</c>                      - in case the airbag of the vehicle involved in the accident is triggered,
    /// *                                          the accident requires important rescue and/or recovery work,
    /// - 3 <c>accidentInvolvingLorry</c>             - in case the accident involves a lorry,
    /// - 4 <c>accidentInvolvingBus</c>               - in case the accident involves a bus,
    /// - 5 <c>accidentInvolvingHazardousMaterials</c>- in case the accident involves hazardous material,
    /// - 6 <c>accidentOnOppositeLane</c>             - in case the accident happens on opposite lanes,
    /// - 7 <c>unsecuredAccident</c>                  - in case the accident is not secured,
    /// - 8 <c>assistanceRequested</c>                - in case rescue and assistance are requested,
    /// - 9-255                                  - reserved for future usage.
    /// </summary>
    [JsonPropertyName("accident2")]
    [Minimum(0)]
    [Maximum(255)]
    public required int Accident2 { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
