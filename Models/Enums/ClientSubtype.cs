using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The subtype or subgroup of the client type. This further specifies the client type. For example it will specify if the client is a passenger car or a truck. See the ClientType description for the supported Subtypes for each client type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ClientSubtype>))]
public sealed record ClientSubtype : StringEnum<ClientSubtype>
{
    private ClientSubtype(string value) : base(value)
    {
    }

    public static readonly ClientSubtype PassengerCar = new("PassengerCar");

    public static readonly ClientSubtype Truck = new("Truck");

    public static readonly ClientSubtype Bus = new("Bus");

    public static readonly ClientSubtype EmergencyVehicle = new("EmergencyVehicle");

    public static readonly ClientSubtype SchoolBus = new("SchoolBus");

    public static readonly ClientSubtype MaintenanceVehicle = new("MaintenanceVehicle");

    public static readonly ClientSubtype Pedestrian = new("Pedestrian");

    public static readonly ClientSubtype Bicycle = new("Bicycle");

    public static readonly ClientSubtype Scooter = new("Scooter");

    public static readonly ClientSubtype Motorcycle = new("Motorcycle");

    public static readonly ClientSubtype RoadSideUnit = new("RoadSideUnit");

    public static readonly ClientSubtype Camera = new("Camera");

    public static readonly ClientSubtype Lidar = new("Lidar");

    public static readonly ClientSubtype Radar = new("Radar");

    public static readonly ClientSubtype InductiveLoop = new("InductiveLoop");

    public static readonly ClientSubtype MagneticSensor = new("MagneticSensor");

    public static readonly ClientSubtype Platform = new("Platform");

    public static readonly ClientSubtype Application = new("Application");

    public static readonly ClientSubtype Na = new("NA");

    public static ClientSubtype FromValue(string value) => FromValueCore(value);
}
