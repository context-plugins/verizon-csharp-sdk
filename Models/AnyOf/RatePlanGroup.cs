using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(RatePlanGroupConverter))]
public record RatePlanGroup
{
    private readonly Optional<RateplantypeObject> _rateplantypeObjectValue;

    private readonly Optional<Rateplantype2> _rateplantype2Value;

    private RatePlanGroup(Optional<RateplantypeObject> rateplantypeObjectValue,
        Optional<Rateplantype2> rateplantype2Value)
    {
        _rateplantypeObjectValue = rateplantypeObjectValue;
        _rateplantype2Value = rateplantype2Value;
    }

    public static RatePlanGroup RateplantypeObject(RateplantypeObject value) =>
        new(Optional<RateplantypeObject>.Some(value), default);

    public static RatePlanGroup Rateplantype2(Rateplantype2 value) =>
        new(default, Optional<Rateplantype2>.Some(value));

    public bool TryGetRateplantypeObject(out RateplantypeObject value) =>
        _rateplantypeObjectValue.TryGetValue(out value);

    public bool TryGetRateplantype2(out Rateplantype2 value) => _rateplantype2Value.TryGetValue(out value);

    public static implicit operator RatePlanGroup(RateplantypeObject value) => RateplantypeObject(value);

    public static implicit operator RatePlanGroup(Rateplantype2 value) => Rateplantype2(value);
}

file sealed class RatePlanGroupConverter : JsonConverter<RatePlanGroup>
{
    public override RatePlanGroup Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<RateplantypeObject>(root, options, out var rateplantypeObjectValue))
        {
            return RatePlanGroup.RateplantypeObject(rateplantypeObjectValue);
        }
        if (JsonSerializer.TryDeserialize<Rateplantype2>(root, options, out var rateplantype2Value))
        {
            return RatePlanGroup.Rateplantype2(rateplantype2Value);
        }
        throw new JsonException($"JSON does not match RateplantypeObject or Rateplantype2 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, RatePlanGroup value, JsonSerializerOptions options)
    {
        if (value.TryGetRateplantypeObject(out var rateplantypeObjectValue))
        {
            JsonSerializer.Serialize(writer, rateplantypeObjectValue, options);
        }
        else if (value.TryGetRateplantype2(out var rateplantype2Value))
        {
            JsonSerializer.Serialize(writer, rateplantype2Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(RatePlanGroup)} contains no valid value to serialize.");
        }
    }
}
