using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(ExtendedAttribute1Converter))]
public record ExtendedAttribute1
{
    private readonly Optional<Gbiattribute15> _gbiattribute15Value;

    private readonly Optional<Gbiattribute25> _gbiattribute25Value;

    private ExtendedAttribute1(Optional<Gbiattribute15> gbiattribute15Value,
        Optional<Gbiattribute25> gbiattribute25Value)
    {
        _gbiattribute15Value = gbiattribute15Value;
        _gbiattribute25Value = gbiattribute25Value;
    }

    public static ExtendedAttribute1 Gbiattribute15(Gbiattribute15 value) =>
        new(Optional<Gbiattribute15>.Some(value), default);

    public static ExtendedAttribute1 Gbiattribute25(Gbiattribute25 value) =>
        new(default, Optional<Gbiattribute25>.Some(value));

    public bool TryGetGbiattribute15(out Gbiattribute15 value) => _gbiattribute15Value.TryGetValue(out value);

    public bool TryGetGbiattribute25(out Gbiattribute25 value) => _gbiattribute25Value.TryGetValue(out value);

    public static implicit operator ExtendedAttribute1(Gbiattribute15 value) => Gbiattribute15(value);

    public static implicit operator ExtendedAttribute1(Gbiattribute25 value) => Gbiattribute25(value);
}

file sealed class ExtendedAttribute1Converter : JsonConverter<ExtendedAttribute1>
{
    public override ExtendedAttribute1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<Gbiattribute15>(root, options, out var gbiattribute15Value))
        {
            return ExtendedAttribute1.Gbiattribute15(gbiattribute15Value);
        }
        if (JsonSerializer.TryDeserialize<Gbiattribute25>(root, options, out var gbiattribute25Value))
        {
            return ExtendedAttribute1.Gbiattribute25(gbiattribute25Value);
        }
        throw new JsonException($"JSON does not match Gbiattribute15 or Gbiattribute25 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ExtendedAttribute1 value, JsonSerializerOptions options)
    {
        if (value.TryGetGbiattribute15(out var gbiattribute15Value))
        {
            JsonSerializer.Serialize(writer, gbiattribute15Value, options);
        }
        else if (value.TryGetGbiattribute25(out var gbiattribute25Value))
        {
            JsonSerializer.Serialize(writer, gbiattribute25Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(ExtendedAttribute1)} contains no valid value to serialize.");
        }
    }
}
