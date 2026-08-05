using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(SmsNumberModelConverter))]
public record SmsNumberModel
{
    private readonly Optional<Cellphonenumber> _cellphonenumberValue;

    private SmsNumberModel(Optional<Cellphonenumber> cellphonenumberValue)
    {
        _cellphonenumberValue = cellphonenumberValue;
    }

    public static SmsNumberModel Cellphonenumber(Cellphonenumber value) =>
        new(Optional<Cellphonenumber>.Some(value));

    public bool TryGetCellphonenumber(out Cellphonenumber value) =>
        _cellphonenumberValue.TryGetValue(out value);

    public static implicit operator SmsNumberModel(Cellphonenumber value) => Cellphonenumber(value);
}

file sealed class SmsNumberModelConverter : JsonConverter<SmsNumberModel>
{
    public override SmsNumberModel Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<Cellphonenumber>(root, options, out var cellphonenumberValue))
        {
            return SmsNumberModel.Cellphonenumber(cellphonenumberValue);
        }
        throw new JsonException($"JSON does not match Cellphonenumber schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, SmsNumberModel value, JsonSerializerOptions options)
    {
        if (value.TryGetCellphonenumber(out var cellphonenumberValue))
        {
            JsonSerializer.Serialize(writer, cellphonenumberValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(SmsNumberModel)} contains no valid value to serialize.");
        }
    }
}
