using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

/// <summary>
/// A data frame to allow sequences of ITIS codes, short text strings, and numerical values to be expressed in the normal ITIS vocabulary method and pattern. Note that the allowed text strings are more limited than the normal ITIS format in order to conserve bandwidth.
/// </summary>
[JsonConverter(typeof(SpeedLimitConverter))]
public record SpeedLimit
{
    private readonly Optional<ItisItemWrapper> _itisItemWrapperValue;

    private readonly Optional<TextPhraseItemWrapper> _textPhraseItemWrapperValue;

    private SpeedLimit(Optional<ItisItemWrapper> itisItemWrapperValue,
        Optional<TextPhraseItemWrapper> textPhraseItemWrapperValue)
    {
        _itisItemWrapperValue = itisItemWrapperValue;
        _textPhraseItemWrapperValue = textPhraseItemWrapperValue;
    }

    public static SpeedLimit ItisItemWrapper(ItisItemWrapper value) =>
        new(Optional<ItisItemWrapper>.Some(value), default);

    public static SpeedLimit TextPhraseItemWrapper(TextPhraseItemWrapper value) =>
        new(default, Optional<TextPhraseItemWrapper>.Some(value));

    public bool TryGetItisItemWrapper(out ItisItemWrapper value) =>
        _itisItemWrapperValue.TryGetValue(out value);

    public bool TryGetTextPhraseItemWrapper(out TextPhraseItemWrapper value) =>
        _textPhraseItemWrapperValue.TryGetValue(out value);

    public static implicit operator SpeedLimit(ItisItemWrapper value) => ItisItemWrapper(value);

    public static implicit operator SpeedLimit(TextPhraseItemWrapper value) => TextPhraseItemWrapper(value);
}

file sealed class SpeedLimitConverter : JsonConverter<SpeedLimit>
{
    public override SpeedLimit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ItisItemWrapper>(root, options, out var itisItemWrapperValue))
        {
            return SpeedLimit.ItisItemWrapper(itisItemWrapperValue);
        }
        if (JsonSerializer.TryDeserialize<TextPhraseItemWrapper>(root, options, out var textPhraseItemWrapperValue))
        {
            return SpeedLimit.TextPhraseItemWrapper(textPhraseItemWrapperValue);
        }
        throw new JsonException($"JSON does not match ItisItemWrapper or TextPhraseItemWrapper schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, SpeedLimit value, JsonSerializerOptions options)
    {
        if (value.TryGetItisItemWrapper(out var itisItemWrapperValue))
        {
            JsonSerializer.Serialize(writer, itisItemWrapperValue, options);
        }
        else if (value.TryGetTextPhraseItemWrapper(out var textPhraseItemWrapperValue))
        {
            JsonSerializer.Serialize(writer, textPhraseItemWrapperValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(SpeedLimit)} contains no valid value to serialize.");
        }
    }
}
