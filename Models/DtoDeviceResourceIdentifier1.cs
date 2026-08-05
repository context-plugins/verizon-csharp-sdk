using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// Device identifiers, one or more are required
/// </summary>
public record DtoDeviceResourceIdentifier1
{
    /// <summary>
    /// the IEEE EUI64 address space used to identify a device. It is supplied by the device manufacturer
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deveui")]
    public string? Deveui { get; init; }

    /// <summary>
    /// This is a UUID value of the device created when the device is onboarded
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceid")]
    public string? Deviceid { get; init; }

    /// <summary>
    /// The Electronic Serial Number (ESN) of the device
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("esn")]
    public int? Esn { get; init; }

    /// <summary>
    /// The 20-digit Integrated Circuit Card ID (SIM card ID)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iccid")]
    public string? Iccid { get; init; }

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
    /// The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("msisdn")]
    public string? Msisdn { get; init; }

    /// <summary>
    /// The UUID of the node the device is associated with
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("node_uuid")]
    public string? NodeUuid { get; init; }

    /// <summary>
    /// The numeric value of the Quick Response (QR) code
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("qrcode")]
    public string? Qrcode { get; init; }

    /// <summary>
    /// The device's serial number
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serial")]
    public string? Serial { get; init; }

    /// <summary>
    /// UUID of the user record, assigned at creation
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }
}
