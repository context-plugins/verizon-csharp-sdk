using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Type of the GeoJSON geometry, must be 'Polygon'.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EtxMapMessageGeofenceGeometry>))]
public sealed record EtxMapMessageGeofenceGeometry : StringEnum<EtxMapMessageGeofenceGeometry>
{
    private EtxMapMessageGeofenceGeometry(string value) : base(value)
    {
    }

    public static readonly EtxMapMessageGeofenceGeometry Polygon = new("Polygon");

    public static EtxMapMessageGeofenceGeometry FromValue(string value) => FromValueCore(value);
}
