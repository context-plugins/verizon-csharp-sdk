using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(KeysChunkConverter))]
public record KeysChunk
{
    private readonly Optional<KeyServicePlan> _keyServicePlanValue;

    private readonly Optional<KeyDataPercentage50> _keyDataPercentage50Value;

    private readonly Optional<KeysmsPercentage50> _keysmsPercentage50Value;

    private readonly Optional<NoOfDaysB4PromoExp> _noOfDaysB4PromoExpValue;

    private readonly Optional<EnablePromoExp> _enablePromoExpValue;

    private KeysChunk(Optional<KeyServicePlan> keyServicePlanValue,
        Optional<KeyDataPercentage50> keyDataPercentage50Value,
        Optional<KeysmsPercentage50> keysmsPercentage50Value,
        Optional<NoOfDaysB4PromoExp> noOfDaysB4PromoExpValue,
        Optional<EnablePromoExp> enablePromoExpValue)
    {
        _keyServicePlanValue = keyServicePlanValue;
        _keyDataPercentage50Value = keyDataPercentage50Value;
        _keysmsPercentage50Value = keysmsPercentage50Value;
        _noOfDaysB4PromoExpValue = noOfDaysB4PromoExpValue;
        _enablePromoExpValue = enablePromoExpValue;
    }

    public static KeysChunk KeyServicePlan(KeyServicePlan value) =>
        new(Optional<KeyServicePlan>.Some(value), default, default, default, default);

    public static KeysChunk KeyDataPercentage50(KeyDataPercentage50 value) =>
        new(default, Optional<KeyDataPercentage50>.Some(value), default, default, default);

    public static KeysChunk KeysmsPercentage50(KeysmsPercentage50 value) =>
        new(default, default, Optional<KeysmsPercentage50>.Some(value), default, default);

    public static KeysChunk NoOfDaysB4PromoExp(NoOfDaysB4PromoExp value) =>
        new(default, default, default, Optional<NoOfDaysB4PromoExp>.Some(value), default);

    public static KeysChunk EnablePromoExp(EnablePromoExp value) =>
        new(default, default, default, default, Optional<EnablePromoExp>.Some(value));

    public bool TryGetKeyServicePlan(out KeyServicePlan value) => _keyServicePlanValue.TryGetValue(out value);

    public bool TryGetKeyDataPercentage50(out KeyDataPercentage50 value) =>
        _keyDataPercentage50Value.TryGetValue(out value);

    public bool TryGetKeysmsPercentage50(out KeysmsPercentage50 value) =>
        _keysmsPercentage50Value.TryGetValue(out value);

    public bool TryGetNoOfDaysB4PromoExp(out NoOfDaysB4PromoExp value) =>
        _noOfDaysB4PromoExpValue.TryGetValue(out value);

    public bool TryGetEnablePromoExp(out EnablePromoExp value) => _enablePromoExpValue.TryGetValue(out value);

    public static implicit operator KeysChunk(KeyServicePlan value) => KeyServicePlan(value);

    public static implicit operator KeysChunk(KeyDataPercentage50 value) => KeyDataPercentage50(value);

    public static implicit operator KeysChunk(KeysmsPercentage50 value) => KeysmsPercentage50(value);

    public static implicit operator KeysChunk(NoOfDaysB4PromoExp value) => NoOfDaysB4PromoExp(value);

    public static implicit operator KeysChunk(EnablePromoExp value) => EnablePromoExp(value);
}

file sealed class KeysChunkConverter : JsonConverter<KeysChunk>
{
    public override KeysChunk Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<KeyServicePlan>(root, options, out var keyServicePlanValue))
        {
            return KeysChunk.KeyServicePlan(keyServicePlanValue);
        }
        if (JsonSerializer.TryDeserialize<KeyDataPercentage50>(root, options, out var keyDataPercentage50Value))
        {
            return KeysChunk.KeyDataPercentage50(keyDataPercentage50Value);
        }
        if (JsonSerializer.TryDeserialize<KeysmsPercentage50>(root, options, out var keysmsPercentage50Value))
        {
            return KeysChunk.KeysmsPercentage50(keysmsPercentage50Value);
        }
        if (JsonSerializer.TryDeserialize<NoOfDaysB4PromoExp>(root, options, out var noOfDaysB4PromoExpValue))
        {
            return KeysChunk.NoOfDaysB4PromoExp(noOfDaysB4PromoExpValue);
        }
        if (JsonSerializer.TryDeserialize<EnablePromoExp>(root, options, out var enablePromoExpValue))
        {
            return KeysChunk.EnablePromoExp(enablePromoExpValue);
        }
        throw new JsonException($"JSON does not match KeyServicePlan or KeyDataPercentage50 or KeysmsPercentage50 or NoOfDaysB4PromoExp or EnablePromoExp schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, KeysChunk value, JsonSerializerOptions options)
    {
        if (value.TryGetKeyServicePlan(out var keyServicePlanValue))
        {
            JsonSerializer.Serialize(writer, keyServicePlanValue, options);
        }
        else if (value.TryGetKeyDataPercentage50(out var keyDataPercentage50Value))
        {
            JsonSerializer.Serialize(writer, keyDataPercentage50Value, options);
        }
        else if (value.TryGetKeysmsPercentage50(out var keysmsPercentage50Value))
        {
            JsonSerializer.Serialize(writer, keysmsPercentage50Value, options);
        }
        else if (value.TryGetNoOfDaysB4PromoExp(out var noOfDaysB4PromoExpValue))
        {
            JsonSerializer.Serialize(writer, noOfDaysB4PromoExpValue, options);
        }
        else if (value.TryGetEnablePromoExp(out var enablePromoExpValue))
        {
            JsonSerializer.Serialize(writer, enablePromoExpValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(KeysChunk)} contains no valid value to serialize.");
        }
    }
}
