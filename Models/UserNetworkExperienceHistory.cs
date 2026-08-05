using System;
using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

public record UserNetworkExperienceHistory
{
    /// <summary>
    /// The billing account ID. This is the same value as the Account ID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingaccountid")]
    public string? Billingaccountid { get; init; }

    /// <summary>
    /// Timestamp of the record
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("createdon")]
    public DateTimeOffset? Createdon { get; init; }

    /// <summary>
    /// Timestamp of the record
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date")]
    public DateTimeOffset? Date { get; init; }

    /// <summary>
    /// This is a score based on combination of network coverage and network outage affecting the device's ability to connect to the network. This is a count of devices that have failed
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devicesbad")]
    public int? Devicesbad { get; init; }

    /// <summary>
    /// This is a score based on combination of network coverage and network outage affecting the device's ability to connect to the network. This is a count of devices that are impaired
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devicesfair")]
    public int? Devicesfair { get; init; }

    /// <summary>
    /// This is a score based on combination of network coverage and network outage affecting the device's ability to connect to the network. This is a count of devices that have no issues
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devicesgood")]
    public int? Devicesgood { get; init; }

    /// <summary>
    /// A count of all devices
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("devicestotal")]
    public int? Devicestotal { get; init; }

    /// <summary>
    /// UUID of the ECPD account the user belongs to
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("foreignid")]
    public string? Foreignid { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hours")]
    [Minimum(0)]
    [Maximum(24)]
    public int? Hours { get; init; }

    /// <summary>
    /// UUID of the user record, assigned at creation
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Timestamp of the record
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastupdated")]
    public DateTimeOffset? Lastupdated { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minutes")]
    [Minimum(0)]
    [Maximum(60)]
    public int? Minutes { get; init; }

    /// <summary>
    /// The resource version
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public string? Version { get; init; }

    /// <summary>
    /// The UUID of the resource version
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("versionid")]
    public string? Versionid { get; init; }
}
