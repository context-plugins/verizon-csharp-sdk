using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Verizon.Models.AnyOf;

namespace Verizon.Models;

/// <summary>
/// Request body for retrieving devices based on vendorID and optional filters
/// </summary>
public record DevicesRequest
{
    /// <summary>
    /// The ID the vendor wants its devices to be registered under. E.g. Verizon, GM, Ford, etc.
    /// </summary>
    [JsonPropertyName("VendorId")]
    [MaxLength(64)]
    [RegularExpression("^[a-zA-Z0-9]+$")]
    public required string VendorId { get; init; }

    /// <summary>
    /// Devices filter criteria or pagination token
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Filter")]
    public Filter? Filter { get; init; }
}
