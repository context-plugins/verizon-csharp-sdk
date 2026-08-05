using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(DeviceFilter1Converter))]
public record DeviceFilter1
{
    private readonly Optional<ESimdeviceId> _esimdeviceIdValue;

    private readonly Optional<DeviceId2> _deviceId2Value;

    private DeviceFilter1(Optional<ESimdeviceId> esimdeviceIdValue, Optional<DeviceId2> deviceId2Value)
    {
        _esimdeviceIdValue = esimdeviceIdValue;
        _deviceId2Value = deviceId2Value;
    }

    public static DeviceFilter1 EsimdeviceId(ESimdeviceId value) =>
        new(Optional<ESimdeviceId>.Some(value), default);

    public static DeviceFilter1 DeviceId2(DeviceId2 value) => new(default, Optional<DeviceId2>.Some(value));

    public bool TryGetEsimdeviceId(out ESimdeviceId value) => _esimdeviceIdValue.TryGetValue(out value);

    public bool TryGetDeviceId2(out DeviceId2 value) => _deviceId2Value.TryGetValue(out value);

    public static implicit operator DeviceFilter1(ESimdeviceId value) => EsimdeviceId(value);

    public static implicit operator DeviceFilter1(DeviceId2 value) => DeviceId2(value);
}

file sealed class DeviceFilter1Converter : JsonConverter<DeviceFilter1>
{
    public override DeviceFilter1 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ESimdeviceId>(root, options, out var esimdeviceIdValue))
        {
            return DeviceFilter1.EsimdeviceId(esimdeviceIdValue);
        }
        if (JsonSerializer.TryDeserialize<DeviceId2>(root, options, out var deviceId2Value))
        {
            return DeviceFilter1.DeviceId2(deviceId2Value);
        }
        throw new JsonException($"JSON does not match ESimdeviceId or DeviceId2 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, DeviceFilter1 value, JsonSerializerOptions options)
    {
        if (value.TryGetEsimdeviceId(out var esimdeviceIdValue))
        {
            JsonSerializer.Serialize(writer, esimdeviceIdValue, options);
        }
        else if (value.TryGetDeviceId2(out var deviceId2Value))
        {
            JsonSerializer.Serialize(writer, deviceId2Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(DeviceFilter1)} contains no valid value to serialize.");
        }
    }
}
