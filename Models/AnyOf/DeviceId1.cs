using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(DeviceId1Converter))]
public record DeviceId1
{
    private readonly Optional<DeviceLabels> _deviceLabelsValue;

    private DeviceId1(Optional<DeviceLabels> deviceLabelsValue)
    {
        _deviceLabelsValue = deviceLabelsValue;
    }

    public static DeviceId1 DeviceLabels(DeviceLabels value) => new(Optional<DeviceLabels>.Some(value));

    public bool TryGetDeviceLabels(out DeviceLabels value) => _deviceLabelsValue.TryGetValue(out value);

    public static implicit operator DeviceId1(DeviceLabels value) => DeviceLabels(value);
}

file sealed class DeviceId1Converter : JsonConverter<DeviceId1>
{
    public override DeviceId1 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<DeviceLabels>(root, options, out var deviceLabelsValue))
        {
            return DeviceId1.DeviceLabels(deviceLabelsValue);
        }
        throw new JsonException($"JSON does not match DeviceLabels schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, DeviceId1 value, JsonSerializerOptions options)
    {
        if (value.TryGetDeviceLabels(out var deviceLabelsValue))
        {
            JsonSerializer.Serialize(writer, deviceLabelsValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(DeviceId1)} contains no valid value to serialize.");
        }
    }
}
