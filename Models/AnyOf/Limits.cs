using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(LimitsConverter))]
public record Limits
{
    private readonly Optional<SpeedItem> _speedItemValue;

    private readonly Optional<HeadingItem> _headingItemValue;

    private Limits(Optional<SpeedItem> speedItemValue, Optional<HeadingItem> headingItemValue)
    {
        _speedItemValue = speedItemValue;
        _headingItemValue = headingItemValue;
    }

    public static Limits SpeedItem(SpeedItem value) => new(Optional<SpeedItem>.Some(value), default);

    public static Limits HeadingItem(HeadingItem value) => new(default, Optional<HeadingItem>.Some(value));

    public bool TryGetSpeedItem(out SpeedItem value) => _speedItemValue.TryGetValue(out value);

    public bool TryGetHeadingItem(out HeadingItem value) => _headingItemValue.TryGetValue(out value);

    public static implicit operator Limits(SpeedItem value) => SpeedItem(value);

    public static implicit operator Limits(HeadingItem value) => HeadingItem(value);
}

file sealed class LimitsConverter : JsonConverter<Limits>
{
    public override Limits Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<SpeedItem>(root, options, out var speedItemValue))
        {
            return Limits.SpeedItem(speedItemValue);
        }
        if (JsonSerializer.TryDeserialize<HeadingItem>(root, options, out var headingItemValue))
        {
            return Limits.HeadingItem(headingItemValue);
        }
        throw new JsonException($"JSON does not match SpeedItem or HeadingItem schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Limits value, JsonSerializerOptions options)
    {
        if (value.TryGetSpeedItem(out var speedItemValue))
        {
            JsonSerializer.Serialize(writer, speedItemValue, options);
        }
        else if (value.TryGetHeadingItem(out var headingItemValue))
        {
            JsonSerializer.Serialize(writer, headingItemValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Limits)} contains no valid value to serialize.");
        }
    }
}
