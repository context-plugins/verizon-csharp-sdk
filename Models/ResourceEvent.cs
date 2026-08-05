using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ResourceEvent
{
    /// <summary>
    /// Not used in this release, future functionality
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountclientid")]
    public string? Accountclientid { get; init; }

    /// <summary>
    /// The URL of the callback listener
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("callbackurl")]
    public string? Callbackurl { get; init; }

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
    /// Error message
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; init; }

    [JsonPropertyName("fieldid")]
    public required string Fieldid { get; init; }

    /// <summary>
    /// Fields to return needed by search
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fields")]
    public DtoFields? Fields { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fieldvalue")]
    [MaxLength(100)]
    public IReadOnlyList<int>? Fieldvalue { get; init; }

    /// <summary>
    /// UUID of the ECPD account the user belongs to
    /// </summary>
    [JsonPropertyName("foreignid")]
    public required string Foreignid { get; init; }

    /// <summary>
    /// UUID of the user record, assigned at creation
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Timestamp of the record
    /// </summary>
    [JsonPropertyName("lastupdated")]
    public required DateTimeOffset Lastupdated { get; init; }

    /// <summary>
    /// The model ID of the device
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modelid")]
    public string? Modelid { get; init; }

    /// <summary>
    /// User defined name of the record
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// A flag to indicate if sensor data is to be aggregated (true) or not
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sensordataaggregation")]
    public bool? Sensordataaggregation { get; init; }

    /// <summary>
    /// The current status of the device or transaction and will be <c>success</c> or <c>failed</c>
    /// </summary>
    [JsonPropertyName("state")]
    public required string State { get; init; }

    /// <summary>
    /// The system-generated UUID of the transaction
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionid")]
    public string? Transactionid { get; init; }

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
