using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

/// <summary>
/// Devices filter criteria or pagination token
/// </summary>
[JsonConverter(typeof(FilterConverter))]
public record Filter
{
    private readonly Optional<DevicesFilter> _devicesFilterValue;

    private readonly Optional<PaginationFilter> _paginationFilterValue;

    private Filter(Optional<DevicesFilter> devicesFilterValue, Optional<PaginationFilter> paginationFilterValue)
    {
        _devicesFilterValue = devicesFilterValue;
        _paginationFilterValue = paginationFilterValue;
    }

    public static Filter DevicesFilter(DevicesFilter value) =>
        new(Optional<DevicesFilter>.Some(value), default);

    public static Filter PaginationFilter(PaginationFilter value) =>
        new(default, Optional<PaginationFilter>.Some(value));

    public bool TryGetDevicesFilter(out DevicesFilter value) => _devicesFilterValue.TryGetValue(out value);

    public bool TryGetPaginationFilter(out PaginationFilter value) =>
        _paginationFilterValue.TryGetValue(out value);

    public static implicit operator Filter(DevicesFilter value) => DevicesFilter(value);

    public static implicit operator Filter(PaginationFilter value) => PaginationFilter(value);
}

file sealed class FilterConverter : JsonConverter<Filter>
{
    public override Filter Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<DevicesFilter>(root, options, out var devicesFilterValue))
        {
            return Filter.DevicesFilter(devicesFilterValue);
        }
        if (JsonSerializer.TryDeserialize<PaginationFilter>(root, options, out var paginationFilterValue))
        {
            return Filter.PaginationFilter(paginationFilterValue);
        }
        throw new JsonException($"JSON does not match DevicesFilter or PaginationFilter schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Filter value, JsonSerializerOptions options)
    {
        if (value.TryGetDevicesFilter(out var devicesFilterValue))
        {
            JsonSerializer.Serialize(writer, devicesFilterValue, options);
        }
        else if (value.TryGetPaginationFilter(out var paginationFilterValue))
        {
            JsonSerializer.Serialize(writer, paginationFilterValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Filter)} contains no valid value to serialize.");
        }
    }
}
