using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(MsgIdConverter))]
public record MsgId
{
    private readonly Optional<FurtherInfoMsgId> _furtherInfoMsgIdValue;

    private readonly Optional<RoadSignMsgId> _roadSignMsgIdValue;

    private MsgId(Optional<FurtherInfoMsgId> furtherInfoMsgIdValue, Optional<RoadSignMsgId> roadSignMsgIdValue)
    {
        _furtherInfoMsgIdValue = furtherInfoMsgIdValue;
        _roadSignMsgIdValue = roadSignMsgIdValue;
    }

    public static MsgId FurtherInfoMsgId(FurtherInfoMsgId value) =>
        new(Optional<FurtherInfoMsgId>.Some(value), default);

    public static MsgId RoadSignMsgId(RoadSignMsgId value) =>
        new(default, Optional<RoadSignMsgId>.Some(value));

    public bool TryGetFurtherInfoMsgId(out FurtherInfoMsgId value) =>
        _furtherInfoMsgIdValue.TryGetValue(out value);

    public bool TryGetRoadSignMsgId(out RoadSignMsgId value) => _roadSignMsgIdValue.TryGetValue(out value);

    public static implicit operator MsgId(FurtherInfoMsgId value) => FurtherInfoMsgId(value);

    public static implicit operator MsgId(RoadSignMsgId value) => RoadSignMsgId(value);
}

file sealed class MsgIdConverter : JsonConverter<MsgId>
{
    public override MsgId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<FurtherInfoMsgId>(root, options, out var furtherInfoMsgIdValue))
        {
            return MsgId.FurtherInfoMsgId(furtherInfoMsgIdValue);
        }
        if (JsonSerializer.TryDeserialize<RoadSignMsgId>(root, options, out var roadSignMsgIdValue))
        {
            return MsgId.RoadSignMsgId(roadSignMsgIdValue);
        }
        throw new JsonException($"JSON does not match FurtherInfoMsgId or RoadSignMsgId schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, MsgId value, JsonSerializerOptions options)
    {
        if (value.TryGetFurtherInfoMsgId(out var furtherInfoMsgIdValue))
        {
            JsonSerializer.Serialize(writer, furtherInfoMsgIdValue, options);
        }
        else if (value.TryGetRoadSignMsgId(out var roadSignMsgIdValue))
        {
            JsonSerializer.Serialize(writer, roadSignMsgIdValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(MsgId)} contains no valid value to serialize.");
        }
    }
}
