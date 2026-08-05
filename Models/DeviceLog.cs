using System;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Device logging information.
/// </summary>
public record DeviceLog
{
    /// <summary>
    /// Device IMEI.
    /// </summary>
    [JsonPropertyName("deviceId")]
    public required string DeviceId { get; init; }

    /// <summary>
    /// Time of log.
    /// </summary>
    [JsonPropertyName("logTime")]
    public required DateTimeOffset LogTime { get; init; }

    /// <summary>
    /// Log type (one of SoftwareUpdate, Event, UserNotification, AgentService, Wireless, WirelessWeb, MobileBroadbandModem, WindowsMDM).
    /// </summary>
    [JsonPropertyName("logType")]
    public required string LogType { get; init; }

    /// <summary>
    /// Event log.
    /// </summary>
    [JsonPropertyName("eventLog")]
    public required string EventLog { get; init; }

    /// <summary>
    /// Base64-encoded contents of binary log file.
    /// </summary>
    [JsonPropertyName("binaryLogFileBase64")]
    public required string BinaryLogFileBase64 { get; init; }

    /// <summary>
    /// File name of binary log file.
    /// </summary>
    [JsonPropertyName("binaryLogFilename")]
    public required string BinaryLogFilename { get; init; }
}
