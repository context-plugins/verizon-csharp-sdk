using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

/// <summary>
/// Request structure for querying MAP records. Provide either regionIntersectionPairs (coordinates) or geoJson, not both.
/// </summary>
[JsonConverter(typeof(MapDataQueryRequestConverter))]
public record MapDataQueryRequest
{
    private readonly Optional<EtxMapMessageIntersectionCoordinates> _etxMapMessageIntersectionCoordinatesValue;

    private readonly Optional<EtxMapMessageGeoJsonPolygon> _etxMapMessageGeoJsonPolygonValue;

    private MapDataQueryRequest(Optional<EtxMapMessageIntersectionCoordinates> etxMapMessageIntersectionCoordinatesValue,
        Optional<EtxMapMessageGeoJsonPolygon> etxMapMessageGeoJsonPolygonValue)
    {
        _etxMapMessageIntersectionCoordinatesValue = etxMapMessageIntersectionCoordinatesValue;
        _etxMapMessageGeoJsonPolygonValue = etxMapMessageGeoJsonPolygonValue;
    }

    public static MapDataQueryRequest EtxMapMessageIntersectionCoordinates(EtxMapMessageIntersectionCoordinates value) =>
        new(Optional<EtxMapMessageIntersectionCoordinates>.Some(value), default);

    public static MapDataQueryRequest EtxMapMessageGeoJsonPolygon(EtxMapMessageGeoJsonPolygon value) =>
        new(default, Optional<EtxMapMessageGeoJsonPolygon>.Some(value));

    public bool TryGetEtxMapMessageIntersectionCoordinates(out EtxMapMessageIntersectionCoordinates value) =>
        _etxMapMessageIntersectionCoordinatesValue.TryGetValue(out value);

    public bool TryGetEtxMapMessageGeoJsonPolygon(out EtxMapMessageGeoJsonPolygon value) =>
        _etxMapMessageGeoJsonPolygonValue.TryGetValue(out value);

    public static implicit operator MapDataQueryRequest(EtxMapMessageIntersectionCoordinates value) =>
        EtxMapMessageIntersectionCoordinates(value);

    public static implicit operator MapDataQueryRequest(EtxMapMessageGeoJsonPolygon value) =>
        EtxMapMessageGeoJsonPolygon(value);
}

file sealed class MapDataQueryRequestConverter : JsonConverter<MapDataQueryRequest>
{
    public override MapDataQueryRequest Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<EtxMapMessageIntersectionCoordinates>(root,
            options,
            out var etxMapMessageIntersectionCoordinatesValue))
        {
            return MapDataQueryRequest.EtxMapMessageIntersectionCoordinates(etxMapMessageIntersectionCoordinatesValue);
        }
        if (JsonSerializer.TryDeserialize<EtxMapMessageGeoJsonPolygon>(root,
            options,
            out var etxMapMessageGeoJsonPolygonValue))
        {
            return MapDataQueryRequest.EtxMapMessageGeoJsonPolygon(etxMapMessageGeoJsonPolygonValue);
        }
        throw new JsonException($"JSON does not match EtxMapMessageIntersectionCoordinates or EtxMapMessageGeoJsonPolygon schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, MapDataQueryRequest value, JsonSerializerOptions options)
    {
        if (value.TryGetEtxMapMessageIntersectionCoordinates(out var etxMapMessageIntersectionCoordinatesValue))
        {
            JsonSerializer.Serialize(writer, etxMapMessageIntersectionCoordinatesValue, options);
        }
        else if (value.TryGetEtxMapMessageGeoJsonPolygon(out var etxMapMessageGeoJsonPolygonValue))
        {
            JsonSerializer.Serialize(writer, etxMapMessageGeoJsonPolygonValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(MapDataQueryRequest)} contains no valid value to serialize.");
        }
    }
}
