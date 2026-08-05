using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DtoExpandedDeviceResponse
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
    /// The Identifier of chipset used by the device
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chipset")]
    public string? Chipset { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("commands")]
    public IReadOnlyDictionary<string, object>? Commands { get; init; }

    /// <summary>
    /// Timestamp of the record
    /// </summary>
    [JsonPropertyName("createdon")]
    public required DateTimeOffset Createdon { get; init; }

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
    /// The Electronic Serial Number (ESN) of the device
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("esn")]
    public int? Esn { get; init; }

    /// <summary>
    /// Fields to return needed by search
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fields")]
    public DtoFields? Fields { get; init; }

    /// <summary>
    /// UUID of the ECPD account the user belongs to
    /// </summary>
    [JsonPropertyName("foreignid")]
    public required string Foreignid { get; init; }

    /// <summary>
    /// The manufacturer's hardware version of the device
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hardwareversion")]
    public string? Hardwareversion { get; init; }

    /// <summary>
    /// The 20-digit Integrated Circuit Card ID (SIM card ID)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iccid")]
    public string? Iccid { get; init; }

    /// <summary>
    /// UUID of the user record, assigned at creation
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The 15-digit International Mobile Equipment ID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("imei")]
    public int? Imei { get; init; }

    /// <summary>
    /// The 64-bit International Mobile Subscriber Identity
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("imsi")]
    public int? Imsi { get; init; }

    /// <summary>
    /// Timestamp of the record
    /// </summary>
    [JsonPropertyName("lastupdated")]
    public required DateTimeOffset Lastupdated { get; init; }

    /// <summary>
    /// licenses assigned to the device
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("licenses")]
    [MaxLength(100)]
    public IReadOnlyList<string>? Licenses { get; init; }

    /// <summary>
    /// The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mac")]
    public string? Mac { get; init; }

    /// <summary>
    /// The manufacturer of the device
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("manufacturer")]
    public string? Manufacturer { get; init; }

    /// <summary>
    /// The 56-bit Mobile Equipment ID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("meid")]
    public string? Meid { get; init; }

    /// <summary>
    /// Detail
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modelmetadata")]
    public object? Modelmetadata { get; init; }

    /// <summary>
    /// The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("msisdn")]
    public string? Msisdn { get; init; }

    /// <summary>
    /// User defined name of the record
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// this field is applicable for BLE sensors. This represents the value of parent gateway device
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("parentdeviceid")]
    public string? Parentdeviceid { get; init; }

    /// <summary>
    /// The device model name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("productmodel")]
    public string? Productmodel { get; init; }

    /// <summary>
    /// The id of the provider who is responible for talking to the device
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("providerid")]
    public string? Providerid { get; init; }

    /// <summary>
    /// The numeric value of the Quick Response (QR) code
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("qrcode")]
    public string? Qrcode { get; init; }

    /// <summary>
    /// The device reference ID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refid")]
    public string? Refid { get; init; }

    /// <summary>
    /// The type of value represented by <c>refid</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refidtype")]
    public string? Refidtype { get; init; }

    /// <summary>
    /// The device's serial number
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serial")]
    public string? Serial { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("services")]
    [MaxLength(100)]
    public IReadOnlyList<string>? Services { get; init; }

    /// <summary>
    /// The Stock Keeping Unit (SKU) number of the device
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sku")]
    public string? Sku { get; init; }

    /// <summary>
    /// the current device software version
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("softwareversion")]
    public string? Softwareversion { get; init; }

    /// <summary>
    /// The current status of the device or transaction and will be <c>success</c> or <c>failed</c>
    /// </summary>
    [JsonPropertyName("state")]
    public required string State { get; init; }

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
