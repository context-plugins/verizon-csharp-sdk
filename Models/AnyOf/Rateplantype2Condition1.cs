using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;
using Verizon.Models.Enums;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(Rateplantype2Condition1Converter))]
public record Rateplantype2Condition1
{
    private readonly Optional<ConditionType> _conditionTypeValue;

    private readonly Optional<ConditionObjectCall> _conditionObjectCallValue;

    private Rateplantype2Condition1(Optional<ConditionType> conditionTypeValue,
        Optional<ConditionObjectCall> conditionObjectCallValue)
    {
        _conditionTypeValue = conditionTypeValue;
        _conditionObjectCallValue = conditionObjectCallValue;
    }

    public static Rateplantype2Condition1 ConditionType(ConditionType value) =>
        new(Optional<ConditionType>.Some(value), default);

    public static Rateplantype2Condition1 ConditionObjectCall(ConditionObjectCall value) =>
        new(default, Optional<ConditionObjectCall>.Some(value));

    public bool TryGetConditionType(out ConditionType value) => _conditionTypeValue.TryGetValue(out value);

    public bool TryGetConditionObjectCall(out ConditionObjectCall value) =>
        _conditionObjectCallValue.TryGetValue(out value);

    public static implicit operator Rateplantype2Condition1(ConditionType value) => ConditionType(value);

    public static implicit operator Rateplantype2Condition1(ConditionObjectCall value) =>
        ConditionObjectCall(value);
}

file sealed class Rateplantype2Condition1Converter : JsonConverter<Rateplantype2Condition1>
{
    public override Rateplantype2Condition1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ConditionType>(root, options, out var conditionTypeValue))
        {
            return Rateplantype2Condition1.ConditionType(conditionTypeValue);
        }
        if (JsonSerializer.TryDeserialize<ConditionObjectCall>(root, options, out var conditionObjectCallValue))
        {
            return Rateplantype2Condition1.ConditionObjectCall(conditionObjectCallValue);
        }
        throw new JsonException($"JSON does not match ConditionType or ConditionObjectCall schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Rateplantype2Condition1 value, JsonSerializerOptions options)
    {
        if (value.TryGetConditionType(out var conditionTypeValue))
        {
            JsonSerializer.Serialize(writer, conditionTypeValue, options);
        }
        else if (value.TryGetConditionObjectCall(out var conditionObjectCallValue))
        {
            JsonSerializer.Serialize(writer, conditionObjectCallValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Rateplantype2Condition1)} contains no valid value to serialize.");
        }
    }
}
