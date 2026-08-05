using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// Optional filter criteria. Can specify one or more of:
/// - ClientType: Filter devices by client type
/// - ClientSubtype: Filter devices by client subtype
/// - MecId: Filter devices by MEC ID
/// - PageSize: Number of devices to return per page
/// <para>
/// Valid combinations:
/// - ClientType only
/// - ClientSubtype only
/// - ClientType and ClientSubtype together
/// - MecId only
/// - MecId and ClientType together
/// - MecId and ClientSubtype together
/// - MecId, ClientType, and ClientSubtype together
/// - PageSize only
/// - PageSize with any of the above combinations
/// </para>
/// <para>
/// If no filter is provided, all devices for the vendor are returned.
/// </para>
/// </summary>
public record DevicesFilter
{
    /// <summary>
    /// The type of the client that is to be registered. This is one of the major traffic participant groups considered in V2X communication. The system uses this value to define which topics the client will be able to publish and subscribe to.
    /// <para>
    /// Values:
    /// - <b>Vehicle</b> - Vehicle with an enclosure around the passengers. (Subtypes: Motorcycle, PassengerCar, Truck, Bus, EmergencyVehicle, SchoolBus, MaintenanceVehicle)
    /// - <b>VulnerableRoadUser</b> - Traffic participants without a protecting enclosure. (Subtypes: Bicycle, Pedestrian, Scooter)
    /// - <b>TrafficLightController</b> - A Traffic light controller system. (Subtypes: NA)
    /// - <b>InfrastructureSensor</b> - Sensors that are deployed in the infrastructure. (Subtypes: RoadSideUnit, Camera, Lidar, Radar, InductiveLoop, MagneticSensor)
    /// - <b>OnboardSensor</b> - Sensors that are onboard on a vehicle(Subtypes: Camera, Lidar, Radar)
    /// - <b>Software</b> - A software system or application. (Subtypes: Platform, Application, NA)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ClientType")]
    public EtxClientType? ClientType { get; init; }

    /// <summary>
    /// The subtype or subgroup of the client type. This further specifies the client type. For example it will specify if the client is a passenger car or a truck. See the ClientType description for the supported Subtypes for each client type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ClientSubtype")]
    public ClientSubtype? ClientSubtype { get; init; }

    /// <summary>
    /// The unique identifier for a Multi-access Edge Computing (MEC) location in the ETX system.
    /// This ID is used to reference and manage MEC locations for registration, update, retrieval, and deletion operations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MecId")]
    [MaxLength(128)]
    [RegularExpression("^[a-z0-9\\-]+$")]
    public string? MecId { get; init; }

    /// <summary>
    /// Number of devices to return per page. If not provided, the server default is used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PageSize")]
    [Minimum(1)]
    [Maximum(500)]
    public int? PageSize { get; init; }
}
