using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(Id2Converter))]
public record Id2
{
    private readonly Optional<ESimdeviceId> _esimdeviceIdValue;

    private readonly Optional<DeviceId2> _deviceId2Value;

    private Id2(Optional<ESimdeviceId> esimdeviceIdValue, Optional<DeviceId2> deviceId2Value)
    {
        _esimdeviceIdValue = esimdeviceIdValue;
        _deviceId2Value = deviceId2Value;
    }

    public static Id2 EsimdeviceId(ESimdeviceId value) => new(Optional<ESimdeviceId>.Some(value), default);

    public static Id2 DeviceId2(DeviceId2 value) => new(default, Optional<DeviceId2>.Some(value));

    public bool TryGetEsimdeviceId(out ESimdeviceId value) => _esimdeviceIdValue.TryGetValue(out value);

    public bool TryGetDeviceId2(out DeviceId2 value) => _deviceId2Value.TryGetValue(out value);

    public static implicit operator Id2(ESimdeviceId value) => EsimdeviceId(value);

    public static implicit operator Id2(DeviceId2 value) => DeviceId2(value);
}

file sealed class Id2Converter : JsonConverter<Id2>
{
    public override Id2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ESimdeviceId>(root, options, out var esimdeviceIdValue))
        {
            return Id2.EsimdeviceId(esimdeviceIdValue);
        }
        if (JsonSerializer.TryDeserialize<DeviceId2>(root, options, out var deviceId2Value))
        {
            return Id2.DeviceId2(deviceId2Value);
        }
        throw new JsonException($"JSON does not match ESimdeviceId or DeviceId2 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Id2 value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(Id2)} contains no valid value to serialize.");
        }
    }
}
