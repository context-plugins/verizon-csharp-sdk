using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<EtxClientType>))]
public sealed record EtxClientType : StringEnum<EtxClientType>
{
    private EtxClientType(string value) : base(value)
    {
    }

    public static readonly EtxClientType Vehicle = new("Vehicle");

    public static readonly EtxClientType VulnerableRoadUser = new("VulnerableRoadUser");

    public static readonly EtxClientType TrafficLightController = new("TrafficLightController");

    public static readonly EtxClientType InfrastructureSensor = new("InfrastructureSensor");

    public static readonly EtxClientType OnboardSensor = new("OnboardSensor");

    public static readonly EtxClientType Software = new("Software");

    public static EtxClientType FromValue(string value) => FromValueCore(value);
}
