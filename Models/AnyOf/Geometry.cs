using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(GeometryConverter))]
public record Geometry
{
    private readonly Optional<LineString> _lineStringValue;

    private readonly Optional<Polygon> _polygonValue;

    private readonly Optional<MultiLineString> _multiLineStringValue;

    private readonly Optional<MultiPolygon> _multiPolygonValue;

    private Geometry(Optional<LineString> lineStringValue,
        Optional<Polygon> polygonValue,
        Optional<MultiLineString> multiLineStringValue,
        Optional<MultiPolygon> multiPolygonValue)
    {
        _lineStringValue = lineStringValue;
        _polygonValue = polygonValue;
        _multiLineStringValue = multiLineStringValue;
        _multiPolygonValue = multiPolygonValue;
    }

    public static Geometry LineString(LineString value) =>
        new(Optional<LineString>.Some(value), default, default, default);

    public static Geometry Polygon(Polygon value) =>
        new(default, Optional<Polygon>.Some(value), default, default);

    public static Geometry MultiLineString(MultiLineString value) =>
        new(default, default, Optional<MultiLineString>.Some(value), default);

    public static Geometry MultiPolygon(MultiPolygon value) =>
        new(default, default, default, Optional<MultiPolygon>.Some(value));

    public bool TryGetLineString(out LineString value) => _lineStringValue.TryGetValue(out value);

    public bool TryGetPolygon(out Polygon value) => _polygonValue.TryGetValue(out value);

    public bool TryGetMultiLineString(out MultiLineString value) =>
        _multiLineStringValue.TryGetValue(out value);

    public bool TryGetMultiPolygon(out MultiPolygon value) => _multiPolygonValue.TryGetValue(out value);

    public static implicit operator Geometry(LineString value) => LineString(value);

    public static implicit operator Geometry(Polygon value) => Polygon(value);

    public static implicit operator Geometry(MultiLineString value) => MultiLineString(value);

    public static implicit operator Geometry(MultiPolygon value) => MultiPolygon(value);
}

file sealed class GeometryConverter : JsonConverter<Geometry>
{
    public override Geometry Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<LineString>(root, options, out var lineStringValue))
        {
            return Geometry.LineString(lineStringValue);
        }
        if (JsonSerializer.TryDeserialize<Polygon>(root, options, out var polygonValue))
        {
            return Geometry.Polygon(polygonValue);
        }
        if (JsonSerializer.TryDeserialize<MultiLineString>(root, options, out var multiLineStringValue))
        {
            return Geometry.MultiLineString(multiLineStringValue);
        }
        if (JsonSerializer.TryDeserialize<MultiPolygon>(root, options, out var multiPolygonValue))
        {
            return Geometry.MultiPolygon(multiPolygonValue);
        }
        throw new JsonException($"JSON does not match LineString or Polygon or MultiLineString or MultiPolygon schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Geometry value, JsonSerializerOptions options)
    {
        if (value.TryGetLineString(out var lineStringValue))
        {
            JsonSerializer.Serialize(writer, lineStringValue, options);
        }
        else if (value.TryGetPolygon(out var polygonValue))
        {
            JsonSerializer.Serialize(writer, polygonValue, options);
        }
        else if (value.TryGetMultiLineString(out var multiLineStringValue))
        {
            JsonSerializer.Serialize(writer, multiLineStringValue, options);
        }
        else if (value.TryGetMultiPolygon(out var multiPolygonValue))
        {
            JsonSerializer.Serialize(writer, multiPolygonValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Geometry)} contains no valid value to serialize.");
        }
    }
}
