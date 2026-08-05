using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(CustomFieldConverter))]
public record CustomField
{
    private readonly Optional<GbikeyValue15> _gbikeyValue15Value;

    private CustomField(Optional<GbikeyValue15> gbikeyValue15Value)
    {
        _gbikeyValue15Value = gbikeyValue15Value;
    }

    public static CustomField GbikeyValue15(GbikeyValue15 value) =>
        new(Optional<GbikeyValue15>.Some(value));

    public bool TryGetGbikeyValue15(out GbikeyValue15 value) => _gbikeyValue15Value.TryGetValue(out value);

    public static implicit operator CustomField(GbikeyValue15 value) => GbikeyValue15(value);
}

file sealed class CustomFieldConverter : JsonConverter<CustomField>
{
    public override CustomField Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<GbikeyValue15>(root, options, out var gbikeyValue15Value))
        {
            return CustomField.GbikeyValue15(gbikeyValue15Value);
        }
        throw new JsonException($"JSON does not match GbikeyValue15 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, CustomField value, JsonSerializerOptions options)
    {
        if (value.TryGetGbikeyValue15(out var gbikeyValue15Value))
        {
            JsonSerializer.Serialize(writer, gbikeyValue15Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(CustomField)} contains no valid value to serialize.");
        }
    }
}
