using System.Collections.Generic;
using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// Property objects for Bluetooth Low-Energy (BLE) devices
/// </summary>
public record SensorInsightsBle
{
    /// <summary>
    /// The data mode the sensor is using
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataMode")]
    public int? DataMode { get; init; }

    /// <summary>
    /// The numeric manufacturer ID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("manufacturerId")]
    public int? ManufacturerId { get; init; }

    /// <summary>
    /// How frequently the device can be scanned
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxNumScan")]
    public int? MaxNumScan { get; init; }

    /// <summary>
    /// The minimum signal strength needed for the sensor to transmit (in Decibels or dB)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minSigStr")]
    public int? MinSigStr { get; init; }

    /// <summary>
    /// The ammount of time to monitor the sensor and varies by device
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("monitorPeriod")]
    public int? MonitorPeriod { get; init; }

    /// <summary>
    /// Values for the manufacturer and these vary by device
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("moreManufId")]
    public IReadOnlyList<object>? MoreManufId { get; init; }

    /// <summary>
    /// The operation mode
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("opMode")]
    public int? OpMode { get; init; }

    /// <summary>
    /// The ammount of time between sensor readings and reports
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportOffset")]
    public int? ReportOffset { get; init; }

    /// <summary>
    /// The ammount of time between reports
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportPeriod")]
    public int? ReportPeriod { get; init; }

    /// <summary>
    /// The report type
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportType")]
    public int? ReportType { get; init; }

    /// <summary>
    /// The ammount of time the sensor is queried for data
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scanDuration")]
    public int? ScanDuration { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
