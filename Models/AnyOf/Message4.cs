using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(Message4Converter))]
public record Message4
{
    private readonly Optional<GiosmsMessage> _giosmsMessageValue;

    private Message4(Optional<GiosmsMessage> giosmsMessageValue)
    {
        _giosmsMessageValue = giosmsMessageValue;
    }

    public static Message4 GiosmsMessage(GiosmsMessage value) => new(Optional<GiosmsMessage>.Some(value));

    public bool TryGetGiosmsMessage(out GiosmsMessage value) => _giosmsMessageValue.TryGetValue(out value);

    public static implicit operator Message4(GiosmsMessage value) => GiosmsMessage(value);
}

file sealed class Message4Converter : JsonConverter<Message4>
{
    public override Message4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<GiosmsMessage>(root, options, out var giosmsMessageValue))
        {
            return Message4.GiosmsMessage(giosmsMessageValue);
        }
        throw new JsonException($"JSON does not match GiosmsMessage schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Message4 value, JsonSerializerOptions options)
    {
        if (value.TryGetGiosmsMessage(out var giosmsMessageValue))
        {
            JsonSerializer.Serialize(writer, giosmsMessageValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Message4)} contains no valid value to serialize.");
        }
    }
}
