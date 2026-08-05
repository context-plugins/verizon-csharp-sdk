using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The current status of the callback response.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RequestStatus>))]
public sealed record RequestStatus : StringEnum<RequestStatus>
{
    private RequestStatus(string value) : base(value)
    {
    }

    public static readonly RequestStatus Pending = new("Pending");

    public static readonly RequestStatus Success = new("Success");

    public static readonly RequestStatus Failure = new("Failure");

    public static RequestStatus FromValue(string value) => FromValueCore(value);
}
