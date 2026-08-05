using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Callback type. Must be 'Fota' for Software Management Services API.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CallbackService>))]
public sealed record CallbackService : StringEnum<CallbackService>
{
    private CallbackService(string value) : base(value)
    {
    }

    public static readonly CallbackService Fota = new("Fota");

    public static CallbackService FromValue(string value) => FromValueCore(value);
}
