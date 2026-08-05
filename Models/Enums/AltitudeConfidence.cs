using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<AltitudeConfidence>))]
public sealed record AltitudeConfidence : StringEnum<AltitudeConfidence>
{
    private AltitudeConfidence(string value) : base(value)
    {
    }

    public static readonly AltitudeConfidence Alt00001 = new("alt-000-01");

    public static readonly AltitudeConfidence Alt00002 = new("alt-000-02");

    public static readonly AltitudeConfidence Alt00005 = new("alt-000-05");

    public static readonly AltitudeConfidence Alt00010 = new("alt-000-10");

    public static readonly AltitudeConfidence Alt00020 = new("alt-000-20");

    public static readonly AltitudeConfidence Alt00050 = new("alt-000-50");

    public static readonly AltitudeConfidence Alt00100 = new("alt-001-00");

    public static readonly AltitudeConfidence Alt00200 = new("alt-002-00");

    public static readonly AltitudeConfidence Alt00500 = new("alt-005-00");

    public static readonly AltitudeConfidence Alt01000 = new("alt-010-00");

    public static readonly AltitudeConfidence Alt02000 = new("alt-020-00");

    public static readonly AltitudeConfidence Alt05000 = new("alt-050-00");

    public static readonly AltitudeConfidence Alt10000 = new("alt-100-00");

    public static readonly AltitudeConfidence Alt20000 = new("alt-200-00");

    public static readonly AltitudeConfidence OutOfRange = new("outOfRange");

    public static readonly AltitudeConfidence Unavailable = new("unavailable");

    public static AltitudeConfidence FromValue(string value) => FromValueCore(value);
}
