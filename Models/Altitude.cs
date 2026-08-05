using System.Text.Json.Serialization;
using Verizon.Core.Validation.Attributes;
using Verizon.Models.Enums;

namespace Verizon.Models;

public record Altitude
{
    /// <summary>
    /// Altitude in a WGS84 co-ordinate system (set to 800001 when unavailable).
    /// The value shall be set to:
    /// - <c>-100000</c> if the altitude is equal to or less than -1000 m,
    /// - <c>n</c> (<c>n &gt; -100000</c> and <c>n &lt; 800000</c>) if the altitude is equal to or less than n  x 0,01 metre and greater than (n-1) x 0,01 metre,
    /// - <c>800000</c> if the altitude  greater than 7999,99 m,
    /// - <c>800001</c> if the information is not available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("altitudeValue")]
    [Minimum(-100000)]
    [Maximum(800001)]
    public int? AltitudeValue { get; init; }

    /// <summary>
    /// Absolute accuracy of a reported altitude value.
    /// The value shall be set to:
    /// - 0  - <c>alt-000-01</c>   - if the confidence value is equal to or less than 0,01 metre,
    /// - 1  - <c>alt-000-02</c>   - if the confidence value is equal to or less than 0,02 metre and greater than 0,01 metre,
    /// - 2  - <c>alt-000-05</c>   - if the confidence value is equal to or less than 0,05 metre and greater than 0,02 metre,
    /// - 3  - <c>alt-000-10</c>   - if the confidence value is equal to or less than 0,1 metre and greater than 0,05 metre,
    /// - 4  - <c>alt-000-20</c>   - if the confidence value is equal to or less than 0,2 metre and greater than 0,1 metre,
    /// - 5  - <c>alt-000-50</c>   - if the confidence value is equal to or less than 0,5 metre and greater than 0,2 metre,
    /// - 6  - <c>alt-001-00</c>   - if the confidence value is equal to or less than 1 metre and greater than 0,5 metre,
    /// - 7  - <c>alt-002-00</c>   - if the confidence value is equal to or less than 2 metres and greater than 1 metre,
    /// - 8  - <c>alt-005-00</c>   - if the confidence value is equal to or less than 5 metres and greater than 2 metres,
    /// - 9  - <c>alt-010-00</c>   - if the confidence value is equal to or less than 10 metres and greater than 5 metres,
    /// - 10 - <c>alt-020-00</c>   - if the confidence value is equal to or less than 20 metres and greater than 10 metres,
    /// - 11 - <c>alt-050-00</c>   - if the confidence value is equal to or less than 50 metres and greater than 20 metres,
    /// - 12 - <c>alt-100-00</c>   - if the confidence value is equal to or less than 100 metres and greater than 50 metres,
    /// - 13 - <c>alt-200-00</c>   - if the confidence value is equal to or less than 200 metres and greater than 100 metres,
    /// - 14 - <c>outOfRange</c>   - if the confidence value is out of range, i.e. greater than 200 metres,
    /// - 15 - <c>unavailable</c>  - if the confidence value is unavailable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("altitudeConfidence")]
    public AltitudeConfidence? AltitudeConfidence { get; init; }
}
