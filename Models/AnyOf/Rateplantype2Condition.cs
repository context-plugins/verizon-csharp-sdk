using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;
using Verizon.Models.Enums;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(Rateplantype2ConditionConverter))]
public record Rateplantype2Condition
{
    private readonly Optional<ConditionType> _conditionTypeValue;

    private readonly Optional<ConditionObjectCall> _conditionObjectCallValue;

    private Rateplantype2Condition(Optional<ConditionType> conditionTypeValue,
        Optional<ConditionObjectCall> conditionObjectCallValue)
    {
        _conditionTypeValue = conditionTypeValue;
        _conditionObjectCallValue = conditionObjectCallValue;
    }

    public static Rateplantype2Condition ConditionType(ConditionType value) =>
        new(Optional<ConditionType>.Some(value), default);

    public static Rateplantype2Condition ConditionObjectCall(ConditionObjectCall value) =>
        new(default, Optional<ConditionObjectCall>.Some(value));

    public bool TryGetConditionType(out ConditionType value) => _conditionTypeValue.TryGetValue(out value);

    public bool TryGetConditionObjectCall(out ConditionObjectCall value) =>
        _conditionObjectCallValue.TryGetValue(out value);

    public static implicit operator Rateplantype2Condition(ConditionType value) => ConditionType(value);

    public static implicit operator Rateplantype2Condition(ConditionObjectCall value) =>
        ConditionObjectCall(value);
}

file sealed class Rateplantype2ConditionConverter : JsonConverter<Rateplantype2Condition>
{
    public override Rateplantype2Condition Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ConditionType>(root, options, out var conditionTypeValue))
        {
            return Rateplantype2Condition.ConditionType(conditionTypeValue);
        }
        if (JsonSerializer.TryDeserialize<ConditionObjectCall>(root, options, out var conditionObjectCallValue))
        {
            return Rateplantype2Condition.ConditionObjectCall(conditionObjectCallValue);
        }
        throw new JsonException($"JSON does not match ConditionType or ConditionObjectCall schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Rateplantype2Condition value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(Rateplantype2Condition)} contains no valid value to serialize.");
        }
    }
}
