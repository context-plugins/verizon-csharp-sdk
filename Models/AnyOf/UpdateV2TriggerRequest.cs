using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(UpdateV2TriggerRequestConverter))]
public record UpdateV2TriggerRequest
{
    private readonly Optional<TriggerType3> _triggerType3Value;

    private readonly Optional<ActiveAnomalyIndicator> _activeAnomalyIndicatorValue;

    private UpdateV2TriggerRequest(Optional<TriggerType3> triggerType3Value,
        Optional<ActiveAnomalyIndicator> activeAnomalyIndicatorValue)
    {
        _triggerType3Value = triggerType3Value;
        _activeAnomalyIndicatorValue = activeAnomalyIndicatorValue;
    }

    public static UpdateV2TriggerRequest TriggerType3(TriggerType3 value) =>
        new(Optional<TriggerType3>.Some(value), default);

    public static UpdateV2TriggerRequest ActiveAnomalyIndicator(ActiveAnomalyIndicator value) =>
        new(default, Optional<ActiveAnomalyIndicator>.Some(value));

    public bool TryGetTriggerType3(out TriggerType3 value) => _triggerType3Value.TryGetValue(out value);

    public bool TryGetActiveAnomalyIndicator(out ActiveAnomalyIndicator value) =>
        _activeAnomalyIndicatorValue.TryGetValue(out value);

    public static implicit operator UpdateV2TriggerRequest(TriggerType3 value) => TriggerType3(value);

    public static implicit operator UpdateV2TriggerRequest(ActiveAnomalyIndicator value) =>
        ActiveAnomalyIndicator(value);
}

file sealed class UpdateV2TriggerRequestConverter : JsonConverter<UpdateV2TriggerRequest>
{
    public override UpdateV2TriggerRequest Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<TriggerType3>(root, options, out var triggerType3Value))
        {
            return UpdateV2TriggerRequest.TriggerType3(triggerType3Value);
        }
        if (JsonSerializer.TryDeserialize<ActiveAnomalyIndicator>(root,
            options,
            out var activeAnomalyIndicatorValue))
        {
            return UpdateV2TriggerRequest.ActiveAnomalyIndicator(activeAnomalyIndicatorValue);
        }
        throw new JsonException($"JSON does not match TriggerType3 or ActiveAnomalyIndicator schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, UpdateV2TriggerRequest value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(UpdateV2TriggerRequest)} contains no valid value to serialize.");
        }
    }
}
