using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(DeviceListWithServiceAddress2Converter))]
public record DeviceListWithServiceAddress2
{
    private readonly Optional<GbideviceIdarray25> _gbideviceIdarray25Value;

    private readonly Optional<GbiaddressAndcustomerinfo25> _gbiaddressAndcustomerinfo25Value;

    private DeviceListWithServiceAddress2(Optional<GbideviceIdarray25> gbideviceIdarray25Value,
        Optional<GbiaddressAndcustomerinfo25> gbiaddressAndcustomerinfo25Value)
    {
        _gbideviceIdarray25Value = gbideviceIdarray25Value;
        _gbiaddressAndcustomerinfo25Value = gbiaddressAndcustomerinfo25Value;
    }

    public static DeviceListWithServiceAddress2 GbideviceIdarray25(GbideviceIdarray25 value) =>
        new(Optional<GbideviceIdarray25>.Some(value), default);

    public static DeviceListWithServiceAddress2 GbiaddressAndcustomerinfo25(GbiaddressAndcustomerinfo25 value) =>
        new(default, Optional<GbiaddressAndcustomerinfo25>.Some(value));

    public bool TryGetGbideviceIdarray25(out GbideviceIdarray25 value) =>
        _gbideviceIdarray25Value.TryGetValue(out value);

    public bool TryGetGbiaddressAndcustomerinfo25(out GbiaddressAndcustomerinfo25 value) =>
        _gbiaddressAndcustomerinfo25Value.TryGetValue(out value);

    public static implicit operator DeviceListWithServiceAddress2(GbideviceIdarray25 value) =>
        GbideviceIdarray25(value);

    public static implicit operator DeviceListWithServiceAddress2(GbiaddressAndcustomerinfo25 value) =>
        GbiaddressAndcustomerinfo25(value);
}

file sealed class DeviceListWithServiceAddress2Converter : JsonConverter<DeviceListWithServiceAddress2>
{
    public override DeviceListWithServiceAddress2 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<GbideviceIdarray25>(root, options, out var gbideviceIdarray25Value))
        {
            return DeviceListWithServiceAddress2.GbideviceIdarray25(gbideviceIdarray25Value);
        }
        if (JsonSerializer.TryDeserialize<GbiaddressAndcustomerinfo25>(root,
            options,
            out var gbiaddressAndcustomerinfo25Value))
        {
            return DeviceListWithServiceAddress2.GbiaddressAndcustomerinfo25(gbiaddressAndcustomerinfo25Value);
        }
        throw new JsonException($"JSON does not match GbideviceIdarray25 or GbiaddressAndcustomerinfo25 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        DeviceListWithServiceAddress2 value,
        JsonSerializerOptions options)
    {
        if (value.TryGetGbideviceIdarray25(out var gbideviceIdarray25Value))
        {
            JsonSerializer.Serialize(writer, gbideviceIdarray25Value, options);
        }
        else if (value.TryGetGbiaddressAndcustomerinfo25(out var gbiaddressAndcustomerinfo25Value))
        {
            JsonSerializer.Serialize(writer, gbiaddressAndcustomerinfo25Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(DeviceListWithServiceAddress2)} contains no valid value to serialize.");
        }
    }
}
