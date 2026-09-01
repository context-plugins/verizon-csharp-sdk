using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

/// <summary>
/// The use of ITIS codes interspersed with free text. The complete set of ITIS codes can be found in Volume Two of the SAE J2540 standard.
/// </summary>
[JsonConverter(typeof(AdvisoryConverter))]
public record Advisory
{
    private readonly Optional<ItisItemWrapper> _itisItemWrapperValue;

    private readonly Optional<TextItemWrapper> _textItemWrapperValue;

    private Advisory(Optional<ItisItemWrapper> itisItemWrapperValue, Optional<TextItemWrapper> textItemWrapperValue)
    {
        _itisItemWrapperValue = itisItemWrapperValue;
        _textItemWrapperValue = textItemWrapperValue;
    }

    public static Advisory ItisItemWrapper(ItisItemWrapper value) =>
        new(Optional<ItisItemWrapper>.Some(value), default);

    public static Advisory TextItemWrapper(TextItemWrapper value) =>
        new(default, Optional<TextItemWrapper>.Some(value));

    public bool TryGetItisItemWrapper(out ItisItemWrapper value) =>
        _itisItemWrapperValue.TryGetValue(out value);

    public bool TryGetTextItemWrapper(out TextItemWrapper value) =>
        _textItemWrapperValue.TryGetValue(out value);

    public static implicit operator Advisory(ItisItemWrapper value) => ItisItemWrapper(value);

    public static implicit operator Advisory(TextItemWrapper value) => TextItemWrapper(value);
}

file sealed class AdvisoryConverter : JsonConverter<Advisory>
{
    public override Advisory Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ItisItemWrapper>(root, options, out var itisItemWrapperValue))
        {
            return Advisory.ItisItemWrapper(itisItemWrapperValue);
        }
        if (JsonSerializer.TryDeserialize<TextItemWrapper>(root, options, out var textItemWrapperValue))
        {
            return Advisory.TextItemWrapper(textItemWrapperValue);
        }
        throw new JsonException($"JSON does not match ItisItemWrapper or TextItemWrapper schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Advisory value, JsonSerializerOptions options)
    {
        if (value.TryGetItisItemWrapper(out var itisItemWrapperValue))
        {
            JsonSerializer.Serialize(writer, itisItemWrapperValue, options);
        }
        else if (value.TryGetTextItemWrapper(out var textItemWrapperValue))
        {
            JsonSerializer.Serialize(writer, textItemWrapperValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Advisory)} contains no valid value to serialize.");
        }
    }
}
