using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(TriggersListOptionsConverter))]
public record TriggersListOptions
{
    private readonly Optional<AnomalyTriggerValue> _anomalyTriggerValueValue;

    private readonly Optional<TriggerType2> _triggerType2Value;

    private TriggersListOptions(Optional<AnomalyTriggerValue> anomalyTriggerValueValue,
        Optional<TriggerType2> triggerType2Value)
    {
        _anomalyTriggerValueValue = anomalyTriggerValueValue;
        _triggerType2Value = triggerType2Value;
    }

    public static TriggersListOptions AnomalyTriggerValue(AnomalyTriggerValue value) =>
        new(Optional<AnomalyTriggerValue>.Some(value), default);

    public static TriggersListOptions TriggerType2(TriggerType2 value) =>
        new(default, Optional<TriggerType2>.Some(value));

    public bool TryGetAnomalyTriggerValue(out AnomalyTriggerValue value) =>
        _anomalyTriggerValueValue.TryGetValue(out value);

    public bool TryGetTriggerType2(out TriggerType2 value) => _triggerType2Value.TryGetValue(out value);

    public static implicit operator TriggersListOptions(AnomalyTriggerValue value) =>
        AnomalyTriggerValue(value);

    public static implicit operator TriggersListOptions(TriggerType2 value) => TriggerType2(value);
}

file sealed class TriggersListOptionsConverter : JsonConverter<TriggersListOptions>
{
    public override TriggersListOptions Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<AnomalyTriggerValue>(root, options, out var anomalyTriggerValueValue))
        {
            return TriggersListOptions.AnomalyTriggerValue(anomalyTriggerValueValue);
        }
        if (JsonSerializer.TryDeserialize<TriggerType2>(root, options, out var triggerType2Value))
        {
            return TriggersListOptions.TriggerType2(triggerType2Value);
        }
        throw new JsonException($"JSON does not match AnomalyTriggerValue or TriggerType2 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TriggersListOptions value, JsonSerializerOptions options)
    {
        if (value.TryGetAnomalyTriggerValue(out var anomalyTriggerValueValue))
        {
            JsonSerializer.Serialize(writer, anomalyTriggerValueValue, options);
        }
        else if (value.TryGetTriggerType2(out var triggerType2Value))
        {
            JsonSerializer.Serialize(writer, triggerType2Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(TriggersListOptions)} contains no valid value to serialize.");
        }
    }
}
