using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

/// <summary>
/// One object per device to be deleted. Each object must contain a kind and id element identifying the device.
/// </summary>
[JsonConverter(typeof(DeviceIdsConverter))]
public record DeviceIds
{
    private readonly Optional<IReadOnlyList<DeviceId>> _listOfDeviceIdValue;

    private readonly Optional<DeviceId> _deviceIdValue;

    private DeviceIds(Optional<IReadOnlyList<DeviceId>> listOfDeviceIdValue, Optional<DeviceId> deviceIdValue)
    {
        _listOfDeviceIdValue = listOfDeviceIdValue;
        _deviceIdValue = deviceIdValue;
    }

    public static DeviceIds ListOfDeviceId(IReadOnlyList<DeviceId> value) =>
        new(Optional<IReadOnlyList<DeviceId>>.Some(value), default);

    public static DeviceIds DeviceId(DeviceId value) => new(default, Optional<DeviceId>.Some(value));

    public bool TryGetListOfDeviceId(out IReadOnlyList<DeviceId> value) =>
        _listOfDeviceIdValue.TryGetValue(out value);

    public bool TryGetDeviceId(out DeviceId value) => _deviceIdValue.TryGetValue(out value);

    public static implicit operator DeviceIds(DeviceId value) => DeviceId(value);
}

file sealed class DeviceIdsConverter : JsonConverter<DeviceIds>
{
    public override DeviceIds Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<IReadOnlyList<DeviceId>>(root, options, out var listOfDeviceIdValue))
        {
            return DeviceIds.ListOfDeviceId(listOfDeviceIdValue);
        }
        if (JsonSerializer.TryDeserialize<DeviceId>(root, options, out var deviceIdValue))
        {
            return DeviceIds.DeviceId(deviceIdValue);
        }
        throw new JsonException($"JSON does not match IReadOnlyList<DeviceId> or DeviceId schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, DeviceIds value, JsonSerializerOptions options)
    {
        if (value.TryGetListOfDeviceId(out var listOfDeviceIdValue))
        {
            JsonSerializer.Serialize(writer, listOfDeviceIdValue, options);
        }
        else if (value.TryGetDeviceId(out var deviceIdValue))
        {
            JsonSerializer.Serialize(writer, deviceIdValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(DeviceIds)} contains no valid value to serialize.");
        }
    }
}
