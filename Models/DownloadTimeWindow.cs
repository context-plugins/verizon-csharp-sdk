using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DownloadTimeWindow
{
    /// <summary>
    /// Device IMEI list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startTime")]
    public string? StartTime { get; init; }

    /// <summary>
    /// Device IMEI list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endTime")]
    public string? EndTime { get; init; }
}
