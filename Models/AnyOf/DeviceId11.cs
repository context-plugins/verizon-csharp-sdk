using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(DeviceId11Converter))]
public record DeviceId11
{
    private readonly Optional<GbideviceId15> _gbideviceId15Value;

    private DeviceId11(Optional<GbideviceId15> gbideviceId15Value)
    {
        _gbideviceId15Value = gbideviceId15Value;
    }

    public static DeviceId11 GbideviceId15(GbideviceId15 value) => new(Optional<GbideviceId15>.Some(value));

    public bool TryGetGbideviceId15(out GbideviceId15 value) => _gbideviceId15Value.TryGetValue(out value);

    public static implicit operator DeviceId11(GbideviceId15 value) => GbideviceId15(value);
}

file sealed class DeviceId11Converter : JsonConverter<DeviceId11>
{
    public override DeviceId11 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<GbideviceId15>(root, options, out var gbideviceId15Value))
        {
            return DeviceId11.GbideviceId15(gbideviceId15Value);
        }
        throw new JsonException($"JSON does not match GbideviceId15 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, DeviceId11 value, JsonSerializerOptions options)
    {
        if (value.TryGetGbideviceId15(out var gbideviceId15Value))
        {
            JsonSerializer.Serialize(writer, gbideviceId15Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(DeviceId11)} contains no valid value to serialize.");
        }
    }
}
