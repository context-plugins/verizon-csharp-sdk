using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(CreateV2TriggerRequestConverter))]
public record CreateV2TriggerRequest
{
    private readonly Optional<TriggerType1> _triggerType1Value;

    private readonly Optional<ActiveAnomalyIndicator> _activeAnomalyIndicatorValue;

    private readonly Optional<ActiveTriggerIndicator> _activeTriggerIndicatorValue;

    private CreateV2TriggerRequest(Optional<TriggerType1> triggerType1Value,
        Optional<ActiveAnomalyIndicator> activeAnomalyIndicatorValue,
        Optional<ActiveTriggerIndicator> activeTriggerIndicatorValue)
    {
        _triggerType1Value = triggerType1Value;
        _activeAnomalyIndicatorValue = activeAnomalyIndicatorValue;
        _activeTriggerIndicatorValue = activeTriggerIndicatorValue;
    }

    public static CreateV2TriggerRequest TriggerType1(TriggerType1 value) =>
        new(Optional<TriggerType1>.Some(value), default, default);

    public static CreateV2TriggerRequest ActiveAnomalyIndicator(ActiveAnomalyIndicator value) =>
        new(default, Optional<ActiveAnomalyIndicator>.Some(value), default);

    public static CreateV2TriggerRequest ActiveTriggerIndicator(ActiveTriggerIndicator value) =>
        new(default, default, Optional<ActiveTriggerIndicator>.Some(value));

    public bool TryGetTriggerType1(out TriggerType1 value) => _triggerType1Value.TryGetValue(out value);

    public bool TryGetActiveAnomalyIndicator(out ActiveAnomalyIndicator value) =>
        _activeAnomalyIndicatorValue.TryGetValue(out value);

    public bool TryGetActiveTriggerIndicator(out ActiveTriggerIndicator value) =>
        _activeTriggerIndicatorValue.TryGetValue(out value);

    public static implicit operator CreateV2TriggerRequest(TriggerType1 value) => TriggerType1(value);

    public static implicit operator CreateV2TriggerRequest(ActiveAnomalyIndicator value) =>
        ActiveAnomalyIndicator(value);

    public static implicit operator CreateV2TriggerRequest(ActiveTriggerIndicator value) =>
        ActiveTriggerIndicator(value);
}

file sealed class CreateV2TriggerRequestConverter : JsonConverter<CreateV2TriggerRequest>
{
    public override CreateV2TriggerRequest Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<TriggerType1>(root, options, out var triggerType1Value))
        {
            return CreateV2TriggerRequest.TriggerType1(triggerType1Value);
        }
        if (JsonSerializer.TryDeserialize<ActiveAnomalyIndicator>(root,
            options,
            out var activeAnomalyIndicatorValue))
        {
            return CreateV2TriggerRequest.ActiveAnomalyIndicator(activeAnomalyIndicatorValue);
        }
        if (JsonSerializer.TryDeserialize<ActiveTriggerIndicator>(root,
            options,
            out var activeTriggerIndicatorValue))
        {
            return CreateV2TriggerRequest.ActiveTriggerIndicator(activeTriggerIndicatorValue);
        }
        throw new JsonException($"JSON does not match TriggerType1 or ActiveAnomalyIndicator or ActiveTriggerIndicator schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, CreateV2TriggerRequest value, JsonSerializerOptions options)
    {
        if (value.TryGetTriggerType1(out var triggerType1Value))
        {
            JsonSerializer.Serialize(writer, triggerType1Value, options);
        }
        else if (value.TryGetActiveAnomalyIndicator(out var activeAnomalyIndicatorValue))
        {
            JsonSerializer.Serialize(writer, activeAnomalyIndicatorValue, options);
        }
        else if (value.TryGetActiveTriggerIndicator(out var activeTriggerIndicatorValue))
        {
            JsonSerializer.Serialize(writer, activeTriggerIndicatorValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(CreateV2TriggerRequest)} contains no valid value to serialize.");
        }
    }
}
