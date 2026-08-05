using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record ResourceUser
{
    /// <summary>
    /// Not used in this release, future functionality
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountclientid")]
    public string? Accountclientid { get; init; }

    /// <summary>
    /// Indicates if terms are agreed to (true) or not
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ackterms")]
    public bool? Ackterms { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acktermson")]
    public DateTimeOffset? Acktermson { get; init; }

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
    /// User credentials. The only valid value is an email address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credentialsid")]
    public string? Credentialsid { get; init; }

    /// <summary>
    /// The type of credential represented by the ID. The only valid value is <c>email</c>
    /// </summary>
    [JsonPropertyName("credentialstype")]
    public required string Credentialstype { get; init; }

    /// <summary>
    /// Name/value pair, where the value is client defined.  The purpose is to keep track of current state per device action.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customdata")]
    public IReadOnlyDictionary<string, object>? Customdata { get; init; }

    /// <summary>
    /// a short description
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// the user name value to display
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("displayname")]
    public string? Displayname { get; init; }

    /// <summary>
    /// Contact email for the group
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    /// <summary>
    /// The first name in the user record
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstname")]
    public string? Firstname { get; init; }

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
    /// The last name in the user record
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastname")]
    public string? Lastname { get; init; }

    /// <summary>
    /// Timestamp of the record
    /// </summary>
    [JsonPropertyName("lastupdated")]
    public required DateTimeOffset Lastupdated { get; init; }

    /// <summary>
    /// The Mobile Directory Number
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mdn")]
    public string? Mdn { get; init; }

    /// <summary>
    /// optional field for middle name or initial
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("middlename")]
    public string? Middlename { get; init; }

    /// <summary>
    /// User defined name of the record
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Virtual field; will not be used in this implementation
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secondarybillingaccountids")]
    [MaxLength(100)]
    public IReadOnlyList<string>? Secondarybillingaccountids { get; init; }

    /// <summary>
    /// The current status of the device or transaction and will be <c>success</c> or <c>failed</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public string? State { get; init; }

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
