using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(TriggervalueChunk2Converter))]
public record TriggervalueChunk2
{
    private readonly Optional<Triggervalues2> _triggervalues2Value;

    private TriggervalueChunk2(Optional<Triggervalues2> triggervalues2Value)
    {
        _triggervalues2Value = triggervalues2Value;
    }

    public static TriggervalueChunk2 Triggervalues2(Triggervalues2 value) =>
        new(Optional<Triggervalues2>.Some(value));

    public bool TryGetTriggervalues2(out Triggervalues2 value) => _triggervalues2Value.TryGetValue(out value);

    public static implicit operator TriggervalueChunk2(Triggervalues2 value) => Triggervalues2(value);
}

file sealed class TriggervalueChunk2Converter : JsonConverter<TriggervalueChunk2>
{
    public override TriggervalueChunk2 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<Triggervalues2>(root, options, out var triggervalues2Value))
        {
            return TriggervalueChunk2.Triggervalues2(triggervalues2Value);
        }
        throw new JsonException($"JSON does not match Triggervalues2 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TriggervalueChunk2 value, JsonSerializerOptions options)
    {
        if (value.TryGetTriggervalues2(out var triggervalues2Value))
        {
            JsonSerializer.Serialize(writer, triggervalues2Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(TriggervalueChunk2)} contains no valid value to serialize.");
        }
    }
}
