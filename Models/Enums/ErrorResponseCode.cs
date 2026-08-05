using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Error Code.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ErrorResponseCode>))]
public sealed record ErrorResponseCode : StringEnum<ErrorResponseCode>
{
    private ErrorResponseCode(string value) : base(value)
    {
    }

    public static readonly ErrorResponseCode Unauthorized = new("UNAUTHORIZED");

    public static readonly ErrorResponseCode InvalidAccess = new("INVALID_ACCESS");

    public static readonly ErrorResponseCode InvalidParameter = new("INVALID_PARAMETER");

    public static readonly ErrorResponseCode InternalError = new("INTERNAL_ERROR");

    public static readonly ErrorResponseCode Success = new("SUCCESS");

    public static ErrorResponseCode FromValue(string value) => FromValueCore(value);
}
