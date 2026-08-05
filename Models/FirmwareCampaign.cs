using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Firmware upgrade information.
/// </summary>
public record FirmwareCampaign
{
    /// <summary>
    /// Upgrade identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Account identifier.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// Campaign name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("campaignName")]
    public string? CampaignName { get; init; }

    /// <summary>
    /// Firmware name (for firmware upgrade only).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firmwareName")]
    public string? FirmwareName { get; init; }

    /// <summary>
    /// Old firmware version (for firmware upgrade only).
    /// </summary>
    [JsonPropertyName("firmwareFrom")]
    public required string FirmwareFrom { get; init; }

    /// <summary>
    /// New firmware version (for firmware upgrade only).
    /// </summary>
    [JsonPropertyName("firmwareTo")]
    public required string FirmwareTo { get; init; }

    /// <summary>
    /// Available values: LWM2M.
    /// </summary>
    [JsonPropertyName("protocol")]
    public string Protocol { get; init; } = "LWM2M";

    [JsonPropertyName("make")]
    public required string Make { get; init; }

    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// Campaign start date.
    /// </summary>
    [JsonPropertyName("startDate")]
    public required DateTimeOffset StartDate { get; init; }

    /// <summary>
    /// Campaign end date.
    /// </summary>
    [JsonPropertyName("endDate")]
    public required DateTimeOffset EndDate { get; init; }

    /// <summary>
    /// List of allowed campaign time windows.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("campaignTimeWindowList")]
    public IReadOnlyList<V3TimeWindow>? CampaignTimeWindowList { get; init; }

    /// <summary>
    /// Campaign status.
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }
}
