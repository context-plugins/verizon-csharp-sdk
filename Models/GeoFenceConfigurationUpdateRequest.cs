using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// Request for /api/v1/application/configurations/geofence PUT endpoint. It requires at least one of vendorId, name, description, geofence, messages and isActive fields to be populated.
/// </summary>
public record GeoFenceConfigurationUpdateRequest
{
    /// <summary>
    /// Name of the configuration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [StringLength(256, MinimumLength = 1)]
    [RegularExpression("^[\\w\\+\\-!()\\`\\[\\]{=};\\\"':,.\\/<>?|\\s]+$")]
    public string? Name { get; init; }

    /// <summary>
    /// Description of the configuration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [StringLength(2048, MinimumLength = 1)]
    [RegularExpression("^[\\w\\+\\-!()\\`\\[\\]{=};\\\"':,.\\/<>?|\\s]+$")]
    public string? Description { get; init; }

    /// <summary>
    /// The GeoJSON representation of geofence. Geofence supports the following geometry types: LineString, Polygon, MultiLineString, and MultiPolygon. The system only supports a single Feature in the FeatureCollection, so only one Line, Polygon, MultiLine or MultiPolygon can be defined within one Geofencing configuration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("geoFence")]
    public GeoFence? GeoFence { get; init; }

    /// <summary>
    /// Select which V2X messaging standard will be used for the message generation. The following options are supported:
    ///   - "etsi": The message will be generated using the ETSI (European) standard (e.g. DENM).
    ///   - "sae": The message will be generated using the SAE J2735 (North American) standard (e.g. RSA, TIM).
    ///   - if not sent while POST, defaults to "sae"
    ///   - mandatory to send "etsi" standard here, if ETSI messages are being sent in config
    /// </summary>
    [JsonPropertyName("messageStandard")]
    public MessageStandard? MessageStandard { get; init; } = MessageStandard.Sae;

    /// <summary>
    /// List of predefined messages that belongs to the geofence. These are the messages that are sent out by the system when the Trigger Condition for the message is met.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("messages")]
    [MinLength(1)]
    [MaxLength(10)]
    public IReadOnlyList<Message>? Messages { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isActive")]
    public bool? IsActive { get; init; }
}
