using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// Device information containing ID, type classification, and associated MEC IDs
/// </summary>
public record DevicesResponse
{
    /// <summary>
    /// The generated ID (UUID v4) for the device. It can be used as:
    ///   - the MQTT Client ID when connecting to the Message Exchange system
    ///   - a parameter when asking for the connection endpoint
    ///   - a parameter when finishing the device registration
    ///   - a parameter when unregistering the device
    /// </summary>
    [JsonPropertyName("DeviceID")]
    public required Guid DeviceId { get; init; }

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

    [JsonPropertyName("MecIds")]
    [MinLength(0)]
    [MaxLength(10)]
    public required IReadOnlyList<string?> MecIds { get; init; }
}
