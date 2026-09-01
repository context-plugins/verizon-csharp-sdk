using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(DeviceListWithServiceAddress1Converter))]
public record DeviceListWithServiceAddress1
{
    private readonly Optional<GbideviceIdarray5> _gbideviceIdarray5Value;

    private readonly Optional<GbiaddressAndcustomerinfo5> _gbiaddressAndcustomerinfo5Value;

    private DeviceListWithServiceAddress1(Optional<GbideviceIdarray5> gbideviceIdarray5Value,
        Optional<GbiaddressAndcustomerinfo5> gbiaddressAndcustomerinfo5Value)
    {
        _gbideviceIdarray5Value = gbideviceIdarray5Value;
        _gbiaddressAndcustomerinfo5Value = gbiaddressAndcustomerinfo5Value;
    }

    public static DeviceListWithServiceAddress1 GbideviceIdarray5(GbideviceIdarray5 value) =>
        new(Optional<GbideviceIdarray5>.Some(value), default);

    public static DeviceListWithServiceAddress1 GbiaddressAndcustomerinfo5(GbiaddressAndcustomerinfo5 value) =>
        new(default, Optional<GbiaddressAndcustomerinfo5>.Some(value));

    public bool TryGetGbideviceIdarray5(out GbideviceIdarray5 value) =>
        _gbideviceIdarray5Value.TryGetValue(out value);

    public bool TryGetGbiaddressAndcustomerinfo5(out GbiaddressAndcustomerinfo5 value) =>
        _gbiaddressAndcustomerinfo5Value.TryGetValue(out value);

    public static implicit operator DeviceListWithServiceAddress1(GbideviceIdarray5 value) =>
        GbideviceIdarray5(value);

    public static implicit operator DeviceListWithServiceAddress1(GbiaddressAndcustomerinfo5 value) =>
        GbiaddressAndcustomerinfo5(value);
}

file sealed class DeviceListWithServiceAddress1Converter : JsonConverter<DeviceListWithServiceAddress1>
{
    public override DeviceListWithServiceAddress1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<GbideviceIdarray5>(root, options, out var gbideviceIdarray5Value))
        {
            return DeviceListWithServiceAddress1.GbideviceIdarray5(gbideviceIdarray5Value);
        }
        if (JsonSerializer.TryDeserialize<GbiaddressAndcustomerinfo5>(root,
            options,
            out var gbiaddressAndcustomerinfo5Value))
        {
            return DeviceListWithServiceAddress1.GbiaddressAndcustomerinfo5(gbiaddressAndcustomerinfo5Value);
        }
        throw new JsonException($"JSON does not match GbideviceIdarray5 or GbiaddressAndcustomerinfo5 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        DeviceListWithServiceAddress1 value,
        JsonSerializerOptions options)
    {
        if (value.TryGetGbideviceIdarray5(out var gbideviceIdarray5Value))
        {
            JsonSerializer.Serialize(writer, gbideviceIdarray5Value, options);
        }
        else if (value.TryGetGbiaddressAndcustomerinfo5(out var gbiaddressAndcustomerinfo5Value))
        {
            JsonSerializer.Serialize(writer, gbiaddressAndcustomerinfo5Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(DeviceListWithServiceAddress1)} contains no valid value to serialize.");
        }
    }
}
