using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(Id1Converter))]
public record Id1
{
    private readonly Optional<DeviceId> _deviceIdValue;

    private readonly Optional<PropertyDeviceId> _propertyDeviceIdValue;

    private Id1(Optional<DeviceId> deviceIdValue, Optional<PropertyDeviceId> propertyDeviceIdValue)
    {
        _deviceIdValue = deviceIdValue;
        _propertyDeviceIdValue = propertyDeviceIdValue;
    }

    public static Id1 DeviceId(DeviceId value) => new(Optional<DeviceId>.Some(value), default);

    public static Id1 PropertyDeviceId(PropertyDeviceId value) =>
        new(default, Optional<PropertyDeviceId>.Some(value));

    public bool TryGetDeviceId(out DeviceId value) => _deviceIdValue.TryGetValue(out value);

    public bool TryGetPropertyDeviceId(out PropertyDeviceId value) =>
        _propertyDeviceIdValue.TryGetValue(out value);

    public static implicit operator Id1(DeviceId value) => DeviceId(value);

    public static implicit operator Id1(PropertyDeviceId value) => PropertyDeviceId(value);
}

file sealed class Id1Converter : JsonConverter<Id1>
{
    public override Id1 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<DeviceId>(root, options, out var deviceIdValue))
        {
            return Id1.DeviceId(deviceIdValue);
        }
        if (JsonSerializer.TryDeserialize<PropertyDeviceId>(root, options, out var propertyDeviceIdValue))
        {
            return Id1.PropertyDeviceId(propertyDeviceIdValue);
        }
        throw new JsonException($"JSON does not match DeviceId or PropertyDeviceId schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Id1 value, JsonSerializerOptions options)
    {
        if (value.TryGetDeviceId(out var deviceIdValue))
        {
            JsonSerializer.Serialize(writer, deviceIdValue, options);
        }
        else if (value.TryGetPropertyDeviceId(out var propertyDeviceIdValue))
        {
            JsonSerializer.Serialize(writer, propertyDeviceIdValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Id1)} contains no valid value to serialize.");
        }
    }
}
