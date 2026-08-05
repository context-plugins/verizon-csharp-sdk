using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The road user types:
///   - Vehicle: Vehicles with a metal box. Example: Car, Truck, Bus, etc.
///   - VulnerableRoadUser: Road users without protective housing. Example: Pedestrian, Cyclist, Motorcyclist, etc.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RoadUserTypes>))]
public sealed record RoadUserTypes : StringEnum<RoadUserTypes>
{
    private RoadUserTypes(string value) : base(value)
    {
    }

    public static readonly RoadUserTypes VulnerableRoadUser = new("VulnerableRoadUser");

    public static readonly RoadUserTypes Vehicle = new("Vehicle");

    public static RoadUserTypes FromValue(string value) => FromValueCore(value);
}
