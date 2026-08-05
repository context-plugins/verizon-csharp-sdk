using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(TriggervalueChunkConverter))]
public record TriggervalueChunk
{
    private readonly Optional<Triggervalues> _triggervaluesValue;

    private TriggervalueChunk(Optional<Triggervalues> triggervaluesValue)
    {
        _triggervaluesValue = triggervaluesValue;
    }

    public static TriggervalueChunk Triggervalues(Triggervalues value) =>
        new(Optional<Triggervalues>.Some(value));

    public bool TryGetTriggervalues(out Triggervalues value) => _triggervaluesValue.TryGetValue(out value);

    public static implicit operator TriggervalueChunk(Triggervalues value) => Triggervalues(value);
}

file sealed class TriggervalueChunkConverter : JsonConverter<TriggervalueChunk>
{
    public override TriggervalueChunk Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<Triggervalues>(root, options, out var triggervaluesValue))
        {
            return TriggervalueChunk.Triggervalues(triggervaluesValue);
        }
        throw new JsonException($"JSON does not match Triggervalues schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TriggervalueChunk value, JsonSerializerOptions options)
    {
        if (value.TryGetTriggervalues(out var triggervaluesValue))
        {
            JsonSerializer.Serialize(writer, triggervaluesValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(TriggervalueChunk)} contains no valid value to serialize.");
        }
    }
}
