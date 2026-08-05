using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(DmV1DevicesActionsSetRequest1Converter))]
public record DmV1DevicesActionsSetRequest1
{
    private readonly Optional<DtoDeviceActionSetRequest> _dtoDeviceActionSetRequestValue;

    private readonly Optional<DtoDeviceCommand> _dtoDeviceCommandValue;

    private DmV1DevicesActionsSetRequest1(Optional<DtoDeviceActionSetRequest> dtoDeviceActionSetRequestValue,
        Optional<DtoDeviceCommand> dtoDeviceCommandValue)
    {
        _dtoDeviceActionSetRequestValue = dtoDeviceActionSetRequestValue;
        _dtoDeviceCommandValue = dtoDeviceCommandValue;
    }

    public static DmV1DevicesActionsSetRequest1 DtoDeviceActionSetRequest(DtoDeviceActionSetRequest value) =>
        new(Optional<DtoDeviceActionSetRequest>.Some(value), default);

    public static DmV1DevicesActionsSetRequest1 DtoDeviceCommand(DtoDeviceCommand value) =>
        new(default, Optional<DtoDeviceCommand>.Some(value));

    public bool TryGetDtoDeviceActionSetRequest(out DtoDeviceActionSetRequest value) =>
        _dtoDeviceActionSetRequestValue.TryGetValue(out value);

    public bool TryGetDtoDeviceCommand(out DtoDeviceCommand value) =>
        _dtoDeviceCommandValue.TryGetValue(out value);

    public static implicit operator DmV1DevicesActionsSetRequest1(DtoDeviceActionSetRequest value) =>
        DtoDeviceActionSetRequest(value);

    public static implicit operator DmV1DevicesActionsSetRequest1(DtoDeviceCommand value) =>
        DtoDeviceCommand(value);
}

file sealed class DmV1DevicesActionsSetRequest1Converter : JsonConverter<DmV1DevicesActionsSetRequest1>
{
    public override DmV1DevicesActionsSetRequest1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<DtoDeviceActionSetRequest>(root,
            options,
            out var dtoDeviceActionSetRequestValue))
        {
            return DmV1DevicesActionsSetRequest1.DtoDeviceActionSetRequest(dtoDeviceActionSetRequestValue);
        }
        if (JsonSerializer.TryDeserialize<DtoDeviceCommand>(root, options, out var dtoDeviceCommandValue))
        {
            return DmV1DevicesActionsSetRequest1.DtoDeviceCommand(dtoDeviceCommandValue);
        }
        throw new JsonException($"JSON does not match DtoDeviceActionSetRequest or DtoDeviceCommand schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        DmV1DevicesActionsSetRequest1 value,
        JsonSerializerOptions options)
    {
        if (value.TryGetDtoDeviceActionSetRequest(out var dtoDeviceActionSetRequestValue))
        {
            JsonSerializer.Serialize(writer, dtoDeviceActionSetRequestValue, options);
        }
        else if (value.TryGetDtoDeviceCommand(out var dtoDeviceCommandValue))
        {
            JsonSerializer.Serialize(writer, dtoDeviceCommandValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(DmV1DevicesActionsSetRequest1)} contains no valid value to serialize.");
        }
    }
}
