using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// A success response includes an array of all matching events. Each event includes the full event resource definition.
/// </summary>
public record SearchDeviceResponse
{
    /// <summary>
    /// The action requested in this event; “change” for device configuration changes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("action")]
    public string? Action { get; init; }

    /// <summary>
    /// The date and time of the change request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("createdon")]
    public string? Createdon { get; init; }

    /// <summary>
    /// The device’s ThingSpace UUID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceid")]
    public string? Deviceid { get; init; }

    /// <summary>
    /// List of fields affected by the event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fields")]
    public Fields2? Fields { get; init; }

    /// <summary>
    /// The unique ID of this ts.event.configuration event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The kind of the ThingSpace resource that is being reported; “ts.event.configuration” for device configuration changes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("kind")]
    public string? Kind { get; init; }

    /// <summary>
    /// The date and time that the event was last updated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastupdated")]
    public string? Lastupdated { get; init; }

    /// <summary>
    /// The name of the event
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The current status of the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public string? State { get; init; }

    /// <summary>
    /// UUIDs of tag resources that are applied to this device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tagids")]
    public IReadOnlyList<string>? Tagids { get; init; }

    /// <summary>
    /// transaction id
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionid")]
    public string? Transactionid { get; init; }

    /// <summary>
    /// The version of the resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public string? Version { get; init; }

    /// <summary>
    /// The version of the resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("versionid")]
    public string? Versionid { get; init; }
}
