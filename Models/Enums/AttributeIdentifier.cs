using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Attribute identifier.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AttributeIdentifier>))]
public sealed record AttributeIdentifier : StringEnum<AttributeIdentifier>
{
    private AttributeIdentifier(string value) : base(value)
    {
    }

    public static readonly AttributeIdentifier NetworkBearer = new("NETWORK_BEARER");

    public static readonly AttributeIdentifier RadioSignalStrength = new("RADIO_SIGNAL_STRENGTH");

    public static readonly AttributeIdentifier LinkQuality = new("LINK_QUALITY");

    public static readonly AttributeIdentifier CellId = new("CELL_ID");

    public static readonly AttributeIdentifier Manufacturer = new("MANUFACTURER");

    public static AttributeIdentifier FromValue(string value) => FromValueCore(value);
}
