using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(UpdateTriggerRequestOptionsConverter))]
public record UpdateTriggerRequestOptions
{
    private readonly Optional<TriggerType3> _triggerType3Value;

    private readonly Optional<ActiveAnomalyIndicator> _activeAnomalyIndicatorValue;

    private UpdateTriggerRequestOptions(Optional<TriggerType3> triggerType3Value,
        Optional<ActiveAnomalyIndicator> activeAnomalyIndicatorValue)
    {
        _triggerType3Value = triggerType3Value;
        _activeAnomalyIndicatorValue = activeAnomalyIndicatorValue;
    }

    public static UpdateTriggerRequestOptions TriggerType3(TriggerType3 value) =>
        new(Optional<TriggerType3>.Some(value), default);

    public static UpdateTriggerRequestOptions ActiveAnomalyIndicator(ActiveAnomalyIndicator value) =>
        new(default, Optional<ActiveAnomalyIndicator>.Some(value));

    public bool TryGetTriggerType3(out TriggerType3 value) => _triggerType3Value.TryGetValue(out value);

    public bool TryGetActiveAnomalyIndicator(out ActiveAnomalyIndicator value) =>
        _activeAnomalyIndicatorValue.TryGetValue(out value);

    public static implicit operator UpdateTriggerRequestOptions(TriggerType3 value) => TriggerType3(value);

    public static implicit operator UpdateTriggerRequestOptions(ActiveAnomalyIndicator value) =>
        ActiveAnomalyIndicator(value);
}

file sealed class UpdateTriggerRequestOptionsConverter : JsonConverter<UpdateTriggerRequestOptions>
{
    public override UpdateTriggerRequestOptions Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<TriggerType3>(root, options, out var triggerType3Value))
        {
            return UpdateTriggerRequestOptions.TriggerType3(triggerType3Value);
        }
        if (JsonSerializer.TryDeserialize<ActiveAnomalyIndicator>(root,
            options,
            out var activeAnomalyIndicatorValue))
        {
            return UpdateTriggerRequestOptions.ActiveAnomalyIndicator(activeAnomalyIndicatorValue);
        }
        throw new JsonException($"JSON does not match TriggerType3 or ActiveAnomalyIndicator schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        UpdateTriggerRequestOptions value,
        JsonSerializerOptions options)
    {
        if (value.TryGetTriggerType3(out var triggerType3Value))
        {
            JsonSerializer.Serialize(writer, triggerType3Value, options);
        }
        else if (value.TryGetActiveAnomalyIndicator(out var activeAnomalyIndicatorValue))
        {
            JsonSerializer.Serialize(writer, activeAnomalyIndicatorValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(UpdateTriggerRequestOptions)} contains no valid value to serialize.");
        }
    }
}
