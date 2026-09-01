using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// The customer name and the address of the device's primary place of use. Leave these fields empty to use the account profile address as the primary place of use. These values will be applied to all devices in the request.If the account is enabled for non-geographic MDNs and the device supports it, the primaryPlaceOfUse address will also be used to derive the MDN for the device.
/// </summary>
public record PlaceOfUse
{
    /// <summary>
    /// The customer address for the line's primary place of use, for line usage taxation.
    /// </summary>
    [JsonPropertyName("address")]
    public required Address Address { get; init; }

    /// <summary>
    /// The customer name to be used for line usage taxation.
    /// </summary>
    [JsonPropertyName("customerName")]
    public required CustomerName CustomerName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
