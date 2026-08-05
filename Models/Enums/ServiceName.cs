using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Service name
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ServiceName>))]
public sealed record ServiceName : StringEnum<ServiceName>
{
    private ServiceName(string value) : base(value)
    {
    }

    public static readonly ServiceName Location = new("Location");

    public static readonly ServiceName Fota = new("fota");

    public static ServiceName FromValue(string value) => FromValueCore(value);
}
