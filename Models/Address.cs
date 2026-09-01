using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// The customer address for the line's primary place of use, for line usage taxation.
/// </summary>
public record Address
{
    /// <summary>
    /// The street address for the line's primary place of use. This must be a physical address for taxation; it cannot be a P.O. box.
    /// </summary>
    [JsonPropertyName("addressLine1")]
    public required string AddressLine1 { get; init; }

    /// <summary>
    /// Optional additional street address information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("addressLine2")]
    public string? AddressLine2 { get; init; }

    /// <summary>
    /// The city for the line's primary place of use.
    /// </summary>
    [JsonPropertyName("city")]
    public required string City { get; init; }

    /// <summary>
    /// The state for the line's primary place of use.
    /// </summary>
    [JsonPropertyName("state")]
    public required string State { get; init; }

    /// <summary>
    /// The ZIP code for the line's primary place of use.
    /// </summary>
    [JsonPropertyName("zip")]
    public required string Zip { get; init; }

    /// <summary>
    /// The ZIP+4 for the line's primary place of use.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("zip4")]
    public string? Zip4 { get; init; }

    /// <summary>
    /// Either “US” or “USA” for the country of the line's primary place of use.
    /// </summary>
    [JsonPropertyName("country")]
    public required string Country { get; init; }

    /// <summary>
    /// A phone number where the customer can be reached.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    public string? Phone { get; init; }

    /// <summary>
    /// A single letter to indicate the customer phone type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneType")]
    public string? PhoneType { get; init; }

    /// <summary>
    /// An email address for the customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
