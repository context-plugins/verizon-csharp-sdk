using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// Response for /v2/clients/registration. It provides a generated device ID and the certificates needed to connect the ETX Message Exchange.
/// </summary>
public record ClientPersistenceResponse
{
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
    /// Structure for the credentials required to connect to the ETX MQTT Message Exchange.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Certificate")]
    public Certificate? Certificate { get; init; }

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
    /// The ID the vendor wants its devices to be registered under. E.g. Verizon, GM, Ford, etc.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("VendorID")]
    [MaxLength(64)]
    [RegularExpression("^[a-zA-Z0-9]+$")]
    public string? VendorId { get; init; }
}
