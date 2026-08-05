using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(Device2Converter))]
public record Device2
{
    private readonly Optional<GbiaccountNameobject5> _gbiaccountNameobject5Value;

    private Device2(Optional<GbiaccountNameobject5> gbiaccountNameobject5Value)
    {
        _gbiaccountNameobject5Value = gbiaccountNameobject5Value;
    }

    public static Device2 GbiaccountNameobject5(GbiaccountNameobject5 value) =>
        new(Optional<GbiaccountNameobject5>.Some(value));

    public bool TryGetGbiaccountNameobject5(out GbiaccountNameobject5 value) =>
        _gbiaccountNameobject5Value.TryGetValue(out value);

    public static implicit operator Device2(GbiaccountNameobject5 value) => GbiaccountNameobject5(value);
}

file sealed class Device2Converter : JsonConverter<Device2>
{
    public override Device2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<GbiaccountNameobject5>(root, options, out var gbiaccountNameobject5Value))
        {
            return Device2.GbiaccountNameobject5(gbiaccountNameobject5Value);
        }
        throw new JsonException($"JSON does not match GbiaccountNameobject5 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Device2 value, JsonSerializerOptions options)
    {
        if (value.TryGetGbiaccountNameobject5(out var gbiaccountNameobject5Value))
        {
            JsonSerializer.Serialize(writer, gbiaccountNameobject5Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(Device2)} contains no valid value to serialize.");
        }
    }
}
