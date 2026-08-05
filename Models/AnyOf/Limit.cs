using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(LimitConverter))]
public record Limit
{
    private readonly Optional<SpeedItem> _speedItemValue;

    private readonly Optional<HeadingItem> _headingItemValue;

    private Limit(Optional<SpeedItem> speedItemValue, Optional<HeadingItem> headingItemValue)
    {
        _speedItemValue = speedItemValue;
        _headingItemValue = headingItemValue;
    }

    public static Limit SpeedItem(SpeedItem value) => new(Optional<SpeedItem>.Some(value), default);

    public static Limit HeadingItem(HeadingItem value) => new(default, Optional<HeadingItem>.Some(value));

    public bool TryGetSpeedItem(out SpeedItem value) => _speedItemValue.TryGetValue(out value);

    public bool TryGetHeadingItem(out HeadingItem value) => _headingItemValue.TryGetValue(out value);

    public static implicit operator Limit(SpeedItem value) => SpeedItem(value);

    public static implicit operator Limit(HeadingItem value) => HeadingItem(value);
}

file sealed class LimitConverter : JsonConverter<Limit>
{
    public override Limit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<SpeedItem>(root, options, out var speedItemValue))
        {
            return Limit.SpeedItem(speedItemValue);
        }
        if (JsonSerializer.TryDeserialize<HeadingItem>(root, options, out var headingItemValue))
        {
            return Limit.HeadingItem(headingItemValue);
        }
        throw new JsonException($"JSON does not match SpeedItem or HeadingItem schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Limit value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(Limit)} contains no valid value to serialize.");
        }
    }
}
