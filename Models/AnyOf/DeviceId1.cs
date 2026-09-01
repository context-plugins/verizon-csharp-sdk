using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(DeviceId1Converter))]
public record DeviceId1
{
    private readonly Optional<ESimDeviceId> _eSimDeviceIdValue;

    private readonly Optional<DeviceId2> _deviceId2Value;

    private DeviceId1(Optional<ESimDeviceId> eSimDeviceIdValue, Optional<DeviceId2> deviceId2Value)
    {
        _eSimDeviceIdValue = eSimDeviceIdValue;
        _deviceId2Value = deviceId2Value;
    }

    public static DeviceId1 ESimDeviceId(ESimDeviceId value) =>
        new(Optional<ESimDeviceId>.Some(value), default);

    public static DeviceId1 DeviceId2(DeviceId2 value) => new(default, Optional<DeviceId2>.Some(value));

    public bool TryGetESimDeviceId(out ESimDeviceId value) => _eSimDeviceIdValue.TryGetValue(out value);

    public bool TryGetDeviceId2(out DeviceId2 value) => _deviceId2Value.TryGetValue(out value);

    public static implicit operator DeviceId1(ESimDeviceId value) => ESimDeviceId(value);

    public static implicit operator DeviceId1(DeviceId2 value) => DeviceId2(value);
}

file sealed class DeviceId1Converter : JsonConverter<DeviceId1>
{
    public override DeviceId1 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ESimDeviceId>(root, options, out var eSimDeviceIdValue))
        {
            return DeviceId1.ESimDeviceId(eSimDeviceIdValue);
        }
        if (JsonSerializer.TryDeserialize<DeviceId2>(root, options, out var deviceId2Value))
        {
            return DeviceId1.DeviceId2(deviceId2Value);
        }
        throw new JsonException($"JSON does not match ESimDeviceId or DeviceId2 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, DeviceId1 value, JsonSerializerOptions options)
    {
        if (value.TryGetESimDeviceId(out var eSimDeviceIdValue))
        {
            JsonSerializer.Serialize(writer, eSimDeviceIdValue, options);
        }
        else if (value.TryGetDeviceId2(out var deviceId2Value))
        {
            JsonSerializer.Serialize(writer, deviceId2Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(DeviceId1)} contains no valid value to serialize.");
        }
    }
}
