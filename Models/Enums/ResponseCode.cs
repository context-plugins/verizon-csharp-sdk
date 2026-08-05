using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Possible response codes.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ResponseCode>))]
public sealed record ResponseCode : StringEnum<ResponseCode>
{
    private ResponseCode(string value) : base(value)
    {
    }

    public static readonly ResponseCode InvalidAccess = new("INVALID_ACCESS");

    public static readonly ResponseCode InvalidParameter = new("INVALID_PARAMETER");

    public static readonly ResponseCode InternalError = new("INTERNAL_ERROR");

    public static readonly ResponseCode Success = new("SUCCESS");

    public static ResponseCode FromValue(string value) => FromValueCore(value);
}
