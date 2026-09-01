using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(Message4Converter))]
public record Message4
{
    private readonly Optional<Message> _messageValue;

    private readonly Optional<Message1> _message1Value;

    private readonly Optional<Message2> _message2Value;

    private readonly Optional<Message3> _message3Value;

    private Message4(Optional<Message> messageValue,
        Optional<Message1> message1Value,
        Optional<Message2> message2Value,
        Optional<Message3> message3Value)
    {
        _messageValue = messageValue;
        _message1Value = message1Value;
        _message2Value = message2Value;
        _message3Value = message3Value;
    }

    public static Message4 Message(Message value) =>
        new(Optional<Message>.Some(value), default, default, default);

    public static Message4 Message1(Message1 value) =>
        new(default, Optional<Message1>.Some(value), default, default);

    public static Message4 Message2(Message2 value) =>
        new(default, default, Optional<Message2>.Some(value), default);

    public static Message4 Message3(Message3 value) =>
        new(default, default, default, Optional<Message3>.Some(value));

    public bool TryGetMessage(out Message value) => _messageValue.TryGetValue(out value);

    public bool TryGetMessage1(out Message1 value) => _message1Value.TryGetValue(out value);

    public bool TryGetMessage2(out Message2 value) => _message2Value.TryGetValue(out value);

    public bool TryGetMessage3(out Message3 value) => _message3Value.TryGetValue(out value);

    public static implicit operator Message4(Message value) => Message(value);

    public static implicit operator Message4(Message1 value) => Message1(value);

    public static implicit operator Message4(Message2 value) => Message2(value);

    public static implicit operator Message4(Message3 value) => Message3(value);
}

file sealed class Message4Converter : JsonConverter<Message4>
{
    public override Message4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<Message>(root, options, out var messageValue))
        {
            return Message4.Message(messageValue);
        }
        if (JsonSerializer.TryDeserialize<Message1>(root, options, out var message1Value))
        {
            return Message4.Message1(message1Value);
        }
        if (JsonSerializer.TryDeserialize<Message2>(root, options, out var message2Value))
        {
            return Message4.Message2(message2Value);
        }
        if (JsonSerializer.TryDeserialize<Message3>(root, options, out var message3Value))
        {
            return Message4.Message3(message3Value);
        }
        throw new JsonException($"JSON does not match Message or Message1 or Message2 or Message3 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Message4 value, JsonSerializerOptions options)
    {
        if (value.TryGetMessage(out var messageValue))
        {
            JsonSerializer.Serialize(writer, messageValue, options);
        }
        else if (value.TryGetMessage1(out var message1Value))
        {
            JsonSerializer.Serialize(writer, message1Value, options);
        }
        else if (value.TryGetMessage2(out var message2Value))
        {
            JsonSerializer.Serialize(writer, message2Value, options);
        }
        else if (value.TryGetMessage3(out var message3Value))
        {
            JsonSerializer.Serialize(writer, message3Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(Message4)} contains no valid value to serialize.");
        }
    }
}
