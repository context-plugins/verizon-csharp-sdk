using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The name of the callback service.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CallbackServiceName>))]
public sealed record CallbackServiceName : StringEnum<CallbackServiceName>
{
    private CallbackServiceName(string value) : base(value)
    {
    }

    public static readonly CallbackServiceName Location = new("Location");

    public static readonly CallbackServiceName DeviceLocation = new("DeviceLocation");

    public static CallbackServiceName FromValue(string value) => FromValueCore(value);
}
