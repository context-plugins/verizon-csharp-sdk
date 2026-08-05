using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// Request for v2/clients/registration endpoint. It requires the Client Type, Subtype and Vendor to be defined.
/// </summary>
public record ClientRegistrationRequestV2
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
    [JsonPropertyName("ClientType")]
    public required EtxClientType ClientType { get; init; }

    /// <summary>
    /// The subtype or subgroup of the client type. This further specifies the client type. For example it will specify if the client is a passenger car or a truck. See the ClientType description for the supported Subtypes for each client type.
    /// </summary>
    [JsonPropertyName("ClientSubtype")]
    public required ClientSubtype ClientSubtype { get; init; }

    /// <summary>
    /// The ID the vendor wants its devices to be registered under. E.g. Verizon, GM, Ford, etc.
    /// </summary>
    [JsonPropertyName("VendorID")]
    [MaxLength(64)]
    [RegularExpression("^[a-zA-Z0-9]+$")]
    public required string VendorId { get; init; }

    /// <summary>
    /// The generated ID (UUID v4) for the device. It can be used as:
    ///   - the MQTT Client ID when connecting to the Message Exchange system
    ///   - a parameter when asking for the connection endpoint
    ///   - a parameter when finishing the device registration
    ///   - a parameter when unregistering the device
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DeviceID")]
    public Guid? DeviceId { get; init; }

    /// <summary>
    /// The IMEI number of the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("IMEI")]
    [MaxLength(19)]
    [RegularExpression("^(\\d{2}-\\d{6}-\\d{6}-\\d{1,2})$|^(\\d{15,16})$")]
    public string? Imei { get; init; }

    /// <summary>
    /// The ICCID number of the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ICCID")]
    [StringLength(20, MinimumLength = 19)]
    [RegularExpression("^(89\\d{17,18})$")]
    public string? Iccid { get; init; }

    /// <summary>
    /// The IMSI number of the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("IMSI")]
    [StringLength(15, MinimumLength = 14)]
    [RegularExpression("^\\d{14,15}$")]
    public string? Imsi { get; init; }
}
