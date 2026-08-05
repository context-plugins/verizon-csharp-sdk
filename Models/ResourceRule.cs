using System;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ResourceRule
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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; init; }

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
    /// User defined name of the record
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("rulechain")]
    public required object Rulechain { get; init; }

    /// <summary>
    /// The syntax of the rule and supports camel and json style syntaxes
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rulesyntax")]
    public string? Rulesyntax { get; init; }

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
