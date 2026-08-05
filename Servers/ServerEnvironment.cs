using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Servers;

[JsonConverter(typeof(StringEnumConverter<ServerEnvironment>))]
public record ServerEnvironment : StringEnum<ServerEnvironment>
{
    public static readonly ServerEnvironment Production = new("Production");
    public static readonly ServerEnvironment Staging = new("Staging");
    public static readonly ServerEnvironment Dev = new("Dev");
    public static readonly ServerEnvironment Qa = new("Qa");
    public static readonly ServerEnvironment MockServerForLimitedAvailabilitySeeQuickStart = new("Mock server for limited availability, see quick start");

    private ServerEnvironment(string value) : base(value)
    {
    }

    internal T Match<T>(Func<T> onProduction,
        Func<T> onStaging,
        Func<T> onDev,
        Func<T> onQa,
        Func<T> onMockServerForLimitedAvailabilitySeeQuickStart) =>
        this switch
        {
            _ when this == Production => onProduction(),
            _ when this == Staging => onStaging(),
            _ when this == Dev => onDev(),
            _ when this == Qa => onQa(),
            _ when this == MockServerForLimitedAvailabilitySeeQuickStart => onMockServerForLimitedAvailabilitySeeQuickStart(),
            _ => throw new ArgumentOutOfRangeException(nameof(ServerEnvironment),
                this,
                $"Unknown {nameof(ServerEnvironment)} value.")
        };

    public static ServerEnvironment Default() => Production;
}
