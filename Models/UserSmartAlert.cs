using System;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record UserSmartAlert
{
    /// <summary>
    /// Not used in this release, future functionality
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountclientid")]
    public string? Accountclientid { get; init; }

    /// <summary>
    /// The billing account ID. This is the same value as the Account ID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingaccountid")]
    public string? Billingaccountid { get; init; }

    /// <summary>
    /// The type of alert and will be either <c>telemetry</c> or <c>infrastructure</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category")]
    public string? Category { get; init; }

    /// <summary>
    /// The condition or threshold for an alert
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("condition")]
    public int? Condition { get; init; }

    /// <summary>
    /// Timestamp of the record
    /// </summary>
    [JsonPropertyName("createdon")]
    public required DateTimeOffset Createdon { get; init; }

    /// <summary>
    /// a short description
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// This is a UUID value of the device created when the device is onboarded
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceid")]
    public string? Deviceid { get; init; }

    /// <summary>
    /// UUID of the ECPD account the user belongs to
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("foreignid")]
    public string? Foreignid { get; init; }

    /// <summary>
    /// UUID of the user record, assigned at creation
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// A flag that indicates if the alarm has been acknowledged
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isacknowledged")]
    public bool? Isacknowledged { get; init; }

    /// <summary>
    /// A flag that indicates if the alarm has been cleared
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iscleared")]
    public bool? Iscleared { get; init; }

    /// <summary>
    /// A flag that indicates if the alarm has been disabled
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isdisabled")]
    public bool? Isdisabled { get; init; }

    /// <summary>
    /// Timestamp of the record
    /// </summary>
    [JsonPropertyName("lastupdated")]
    public required DateTimeOffset Lastupdated { get; init; }

    /// <summary>
    /// User defined name of the record
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The UUID of a rule for alerts
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ruleid")]
    public string? Ruleid { get; init; }

    /// <summary>
    /// The threshold value to trigger an alert and will be Critical, Major or Minor
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("severity")]
    public string? Severity { get; init; }

    /// <summary>
    /// The current status of the device or transaction and will be <c>success</c> or <c>failed</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public string? State { get; init; }

    /// <summary>
    /// template of the rule which triggered a given alert
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("template")]
    public string? Template { get; init; }

    /// <summary>
    /// The resource version
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public string? Version { get; init; }

    /// <summary>
    /// The UUID of the resource version
    /// </summary>
    [JsonPropertyName("versionid")]
    public required string Versionid { get; init; }
}
