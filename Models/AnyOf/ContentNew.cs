using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

/// <summary>
/// It contains information that extends the original traveler data
/// frame to enable addition of future entities. Friction information is the first entity included in the new part three content.
/// </summary>
[JsonConverter(typeof(ContentNewConverter))]
public record ContentNew
{
    private readonly Optional<ContentFrictionInfo> _contentFrictionInfoValue;

    private ContentNew(Optional<ContentFrictionInfo> contentFrictionInfoValue)
    {
        _contentFrictionInfoValue = contentFrictionInfoValue;
    }

    public static ContentNew ContentFrictionInfo(ContentFrictionInfo value) =>
        new(Optional<ContentFrictionInfo>.Some(value));

    public bool TryGetContentFrictionInfo(out ContentFrictionInfo value) =>
        _contentFrictionInfoValue.TryGetValue(out value);

    public static implicit operator ContentNew(ContentFrictionInfo value) => ContentFrictionInfo(value);
}

file sealed class ContentNewConverter : JsonConverter<ContentNew>
{
    public override ContentNew Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ContentFrictionInfo>(root, options, out var contentFrictionInfoValue))
        {
            return ContentNew.ContentFrictionInfo(contentFrictionInfoValue);
        }
        throw new JsonException($"JSON does not match ContentFrictionInfo schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ContentNew value, JsonSerializerOptions options)
    {
        if (value.TryGetContentFrictionInfo(out var contentFrictionInfoValue))
        {
            JsonSerializer.Serialize(writer, contentFrictionInfoValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ContentNew)} contains no valid value to serialize.");
        }
    }
}
