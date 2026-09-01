using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Models.Enums;

namespace Verizon.Models;

/// <summary>
/// Response for /api/v1/application/configurations/geofence endpoint. It provides a response if the configuration was created and saved in the system.
/// </summary>
public record GeoFenceConfigurationResponse
{
    /// <summary>
    /// The generated ID (UUID v4) for the configuration. It has to be used when asking for changing any of the configuration parameters.
    /// </summary>
    [JsonPropertyName("id")]
    [StringLength(36, MinimumLength = 32)]
    [RegularExpression("^[0-9a-fA-F]{8}-?[0-9a-fA-F]{4}-?4[0-9a-fA-F]{3}-?[89abAB][0-9a-fA-F]{3}-?[0-9a-fA-F]{12}$")]
    public required string Id { get; init; }

    /// <summary>
    /// The vendor that the configuration belongs to. E.g. Verizon, GM, Ford, etc.
    /// </summary>
    [JsonPropertyName("vendorId")]
    [StringLength(64, MinimumLength = 1)]
    [RegularExpression("^[a-zA-Z0-9]+$")]
    public required string VendorId { get; init; }

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
    [JsonPropertyName("geoFence")]
    public required GeoFence GeoFence { get; init; }

    /// <summary>
    /// Select which V2X messaging standard will be used for the message generation. The following options are supported:
    ///   - "etsi": The message will be generated using the ETSI (European) standard (e.g. DENM).
    ///   - "sae": The message will be generated using the SAE J2735 (North American) standard (e.g. RSA, TIM).
    ///   - if not sent while POST, defaults to "sae"
    ///   - mandatory to send "etsi" standard here, if ETSI messages are being sent in config
    /// </summary>
    [JsonPropertyName("messageStandard")]
    public MessageStandard MessageStandard { get; init; } = MessageStandard.Sae;

    /// <summary>
    /// List of predefined messages that belongs to the geofence. These are the messages that are sent out by the system when the Trigger Condition for the message is met.
    /// </summary>
    [JsonPropertyName("messages")]
    [MinLength(1)]
    [MaxLength(10)]
    public required IReadOnlyList<Message> Messages { get; init; }

    [JsonPropertyName("isActive")]
    public required bool IsActive { get; init; }
}
