using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(DeviceId21Converter))]
public record DeviceId21
{
    private readonly Optional<ESimdeviceId> _esimdeviceIdValue;

    private readonly Optional<DeviceId2> _deviceId2Value;

    private DeviceId21(Optional<ESimdeviceId> esimdeviceIdValue, Optional<DeviceId2> deviceId2Value)
    {
        _esimdeviceIdValue = esimdeviceIdValue;
        _deviceId2Value = deviceId2Value;
    }

    public static DeviceId21 EsimdeviceId(ESimdeviceId value) =>
        new(Optional<ESimdeviceId>.Some(value), default);

    public static DeviceId21 DeviceId2(DeviceId2 value) => new(default, Optional<DeviceId2>.Some(value));

    public bool TryGetEsimdeviceId(out ESimdeviceId value) => _esimdeviceIdValue.TryGetValue(out value);

    public bool TryGetDeviceId2(out DeviceId2 value) => _deviceId2Value.TryGetValue(out value);

    public static implicit operator DeviceId21(ESimdeviceId value) => EsimdeviceId(value);

    public static implicit operator DeviceId21(DeviceId2 value) => DeviceId2(value);
}

file sealed class DeviceId21Converter : JsonConverter<DeviceId21>
{
    public override DeviceId21 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ESimdeviceId>(root, options, out var esimdeviceIdValue))
        {
            return DeviceId21.EsimdeviceId(esimdeviceIdValue);
        }
        if (JsonSerializer.TryDeserialize<DeviceId2>(root, options, out var deviceId2Value))
        {
            return DeviceId21.DeviceId2(deviceId2Value);
        }
        throw new JsonException($"JSON does not match ESimdeviceId or DeviceId2 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, DeviceId21 value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(DeviceId21)} contains no valid value to serialize.");
        }
    }
}
