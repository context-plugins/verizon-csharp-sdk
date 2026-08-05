using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DtoDeviceConfig
{
    /// <summary>
    /// Property objects for Bluetooth Low-Energy (BLE) devices
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ble")]
    public SensorInsightsBle? Ble { get; init; }
}
