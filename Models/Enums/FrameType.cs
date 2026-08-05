using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The frameType data element provides the type of message to follow in the rest of the message frame structure. The following frame types are supported:
///  - unknown
///  - advisory
///  - roadSignage
///  - commercialSignage
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FrameType>))]
public sealed record FrameType : StringEnum<FrameType>
{
    private FrameType(string value) : base(value)
    {
    }

    public static readonly FrameType Unknown = new("unknown");

    public static readonly FrameType Advisory = new("advisory");

    public static readonly FrameType RoadSignage = new("roadSignage");

    public static readonly FrameType CommercialSignage = new("commercialSignage");

    public static FrameType FromValue(string value) => FromValueCore(value);
}
