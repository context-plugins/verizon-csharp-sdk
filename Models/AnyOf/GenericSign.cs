using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

/// <summary>
/// A data frame to allow sequences of ITIS codes, short text strings, and numerical values to be expressed in the normal ITIS vocabulary method and pattern. Note that the allowed text strings are more limited than the normal ITIS format in order to conserve bandwidth.
/// </summary>
[JsonConverter(typeof(GenericSignConverter))]
public record GenericSign
{
    private readonly Optional<ItisitemWrapper> _itisitemWrapperValue;

    private readonly Optional<TextPhraseItemWrapper> _textPhraseItemWrapperValue;

    private GenericSign(Optional<ItisitemWrapper> itisitemWrapperValue,
        Optional<TextPhraseItemWrapper> textPhraseItemWrapperValue)
    {
        _itisitemWrapperValue = itisitemWrapperValue;
        _textPhraseItemWrapperValue = textPhraseItemWrapperValue;
    }

    public static GenericSign ItisitemWrapper(ItisitemWrapper value) =>
        new(Optional<ItisitemWrapper>.Some(value), default);

    public static GenericSign TextPhraseItemWrapper(TextPhraseItemWrapper value) =>
        new(default, Optional<TextPhraseItemWrapper>.Some(value));

    public bool TryGetItisitemWrapper(out ItisitemWrapper value) =>
        _itisitemWrapperValue.TryGetValue(out value);

    public bool TryGetTextPhraseItemWrapper(out TextPhraseItemWrapper value) =>
        _textPhraseItemWrapperValue.TryGetValue(out value);

    public static implicit operator GenericSign(ItisitemWrapper value) => ItisitemWrapper(value);

    public static implicit operator GenericSign(TextPhraseItemWrapper value) => TextPhraseItemWrapper(value);
}

file sealed class GenericSignConverter : JsonConverter<GenericSign>
{
    public override GenericSign Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ItisitemWrapper>(root, options, out var itisitemWrapperValue))
        {
            return GenericSign.ItisitemWrapper(itisitemWrapperValue);
        }
        if (JsonSerializer.TryDeserialize<TextPhraseItemWrapper>(root, options, out var textPhraseItemWrapperValue))
        {
            return GenericSign.TextPhraseItemWrapper(textPhraseItemWrapperValue);
        }
        throw new JsonException($"JSON does not match ItisitemWrapper or TextPhraseItemWrapper schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, GenericSign value, JsonSerializerOptions options)
    {
        if (value.TryGetItisitemWrapper(out var itisitemWrapperValue))
        {
            JsonSerializer.Serialize(writer, itisitemWrapperValue, options);
        }
        else if (value.TryGetTextPhraseItemWrapper(out var textPhraseItemWrapperValue))
        {
            JsonSerializer.Serialize(writer, textPhraseItemWrapperValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(GenericSign)} contains no valid value to serialize.");
        }
    }
}
