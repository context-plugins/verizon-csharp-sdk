using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

/// <summary>
/// The use of ITIS codes interspersed with free text. The complete set of ITIS codes can be found in Volume Two of the SAE J2540 standard.
/// </summary>
[JsonConverter(typeof(AdvisoryItemConverter))]
public record AdvisoryItem
{
    private readonly Optional<ItisitemWrapper> _itisitemWrapperValue;

    private readonly Optional<TextItemWrapper> _textItemWrapperValue;

    private AdvisoryItem(Optional<ItisitemWrapper> itisitemWrapperValue,
        Optional<TextItemWrapper> textItemWrapperValue)
    {
        _itisitemWrapperValue = itisitemWrapperValue;
        _textItemWrapperValue = textItemWrapperValue;
    }

    public static AdvisoryItem ItisitemWrapper(ItisitemWrapper value) =>
        new(Optional<ItisitemWrapper>.Some(value), default);

    public static AdvisoryItem TextItemWrapper(TextItemWrapper value) =>
        new(default, Optional<TextItemWrapper>.Some(value));

    public bool TryGetItisitemWrapper(out ItisitemWrapper value) =>
        _itisitemWrapperValue.TryGetValue(out value);

    public bool TryGetTextItemWrapper(out TextItemWrapper value) =>
        _textItemWrapperValue.TryGetValue(out value);

    public static implicit operator AdvisoryItem(ItisitemWrapper value) => ItisitemWrapper(value);

    public static implicit operator AdvisoryItem(TextItemWrapper value) => TextItemWrapper(value);
}

file sealed class AdvisoryItemConverter : JsonConverter<AdvisoryItem>
{
    public override AdvisoryItem Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ItisitemWrapper>(root, options, out var itisitemWrapperValue))
        {
            return AdvisoryItem.ItisitemWrapper(itisitemWrapperValue);
        }
        if (JsonSerializer.TryDeserialize<TextItemWrapper>(root, options, out var textItemWrapperValue))
        {
            return AdvisoryItem.TextItemWrapper(textItemWrapperValue);
        }
        throw new JsonException($"JSON does not match ItisitemWrapper or TextItemWrapper schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, AdvisoryItem value, JsonSerializerOptions options)
    {
        if (value.TryGetItisitemWrapper(out var itisitemWrapperValue))
        {
            JsonSerializer.Serialize(writer, itisitemWrapperValue, options);
        }
        else if (value.TryGetTextItemWrapper(out var textItemWrapperValue))
        {
            JsonSerializer.Serialize(writer, textItemWrapperValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(AdvisoryItem)} contains no valid value to serialize.");
        }
    }
}
