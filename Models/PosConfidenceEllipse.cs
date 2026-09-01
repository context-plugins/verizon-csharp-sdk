using System.Text.Json.Serialization;
using Verizon.Core.Models;
using Verizon.Core.Validation.Attributes;

namespace Verizon.Models;

public record PosConfidenceEllipse
{
    /// <summary>
    /// Absolute position accuracy in one of the axis direction as defined in a shape of ellipse with a predefined confidence level (set to 4095 when unavailable).
    /// The value shall be set to:
    /// - <c>n</c> (<c>n &gt; 0</c> and <c>n &lt; 4094</c>) if the accuracy is equal to or less than n * 0,01 metre,
    /// - <c>4094</c> if the accuracy is out of range, i.e. greater than 4,093 m,
    /// - <c>4095</c> if the accuracy information is unavailable.
    /// The value 0 shall not be used.
    /// </summary>
    [JsonPropertyName("semiMajorConfidence")]
    [Minimum(0)]
    [Maximum(4095)]
    public required int SemiMajorConfidence { get; init; }

    /// <summary>
    /// Absolute position accuracy in one of the axis direction as defined in a shape of ellipse with a predefined confidence level (set to 4095 when unavailable).
    /// The value shall be set to:
    /// - <c>n</c> (<c>n &gt; 0</c> and <c>n &lt; 4094</c>) if the accuracy is equal to or less than n * 0,01 metre,
    /// - <c>4094</c> if the accuracy is out of range, i.e. greater than 4,093 m,
    /// - <c>4095</c> if the accuracy information is unavailable.
    /// The value 0 shall not be used.
    /// </summary>
    [JsonPropertyName("semiMinorConfidence")]
    [Minimum(0)]
    [Maximum(4095)]
    public required int SemiMinorConfidence { get; init; }

    /// <summary>
    /// An angle value in degrees described in the WGS84 reference system with respect to the WGS84 north.
    /// The value shall be set to:
    /// - wgs84North  (0),
    /// - wgs84East   (900),
    /// - wgs84South  (1800),
    /// - wgs84West   (2700),
    /// - doNotUse    (3600),
    /// - unavailable (3601)
    /// </summary>
    [JsonPropertyName("semiMajorOrientation")]
    [Minimum(0)]
    [Maximum(3601)]
    public required int SemiMajorOrientation { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
