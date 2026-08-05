using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(Device1Converter))]
public record Device1
{
    private readonly Optional<IReadOnlyList<DeviceIdarray>> _listOfDeviceIdarrayValue;

    private Device1(Optional<IReadOnlyList<DeviceIdarray>> listOfDeviceIdarrayValue)
    {
        _listOfDeviceIdarrayValue = listOfDeviceIdarrayValue;
    }

    public static Device1 ListOfDeviceIdarray(IReadOnlyList<DeviceIdarray> value) =>
        new(Optional<IReadOnlyList<DeviceIdarray>>.Some(value));

    public bool TryGetListOfDeviceIdarray(out IReadOnlyList<DeviceIdarray> value) =>
        _listOfDeviceIdarrayValue.TryGetValue(out value);
}

file sealed class Device1Converter : JsonConverter<Device1>
{
    public override Device1 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<IReadOnlyList<DeviceIdarray>>(root,
            options,
            out var listOfDeviceIdarrayValue))
        {
            return Device1.ListOfDeviceIdarray(listOfDeviceIdarrayValue);
        }
        throw new JsonException($"JSON does not match IReadOnlyList<DeviceIdarray> schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Device1 value, JsonSerializerOptions options)
    {
        if (value.TryGetListOfDeviceIdarray(out var listOfDeviceIdarrayValue))
        {
            JsonSerializer.Serialize(writer, listOfDeviceIdarrayValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Device1)} contains no valid value to serialize.");
        }
    }
}
