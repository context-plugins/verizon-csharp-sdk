using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

/// <summary>
/// Indicates the composition of the surface of the roadway for use in estimation of friction.
/// </summary>
[JsonConverter(typeof(DescriptionOfRoadSurfaceConverter))]
public record DescriptionOfRoadSurface
{
    private readonly Optional<DescriptionOfRoadSurfacePortlandCement> _descriptionOfRoadSurfacePortlandCementValue;

    private readonly Optional<DescriptionOfRoadSurfaceAsphaltOrTar> _descriptionOfRoadSurfaceAsphaltOrTarValue;

    private readonly Optional<DescriptionOfRoadSurfaceGravel> _descriptionOfRoadSurfaceGravelValue;

    private readonly Optional<DescriptionOfRoadSurfaceGrass> _descriptionOfRoadSurfaceGrassValue;

    private readonly Optional<DescriptionOfRoadSurfaceCinders> _descriptionOfRoadSurfaceCindersValue;

    private readonly Optional<DescriptionOfRoadSurfaceRock> _descriptionOfRoadSurfaceRockValue;

    private readonly Optional<DescriptionOfRoadSurfaceIce> _descriptionOfRoadSurfaceIceValue;

    private readonly Optional<DescriptionOfRoadSurfaceSnow> _descriptionOfRoadSurfaceSnowValue;

    private DescriptionOfRoadSurface(Optional<DescriptionOfRoadSurfacePortlandCement> descriptionOfRoadSurfacePortlandCementValue,
        Optional<DescriptionOfRoadSurfaceAsphaltOrTar> descriptionOfRoadSurfaceAsphaltOrTarValue,
        Optional<DescriptionOfRoadSurfaceGravel> descriptionOfRoadSurfaceGravelValue,
        Optional<DescriptionOfRoadSurfaceGrass> descriptionOfRoadSurfaceGrassValue,
        Optional<DescriptionOfRoadSurfaceCinders> descriptionOfRoadSurfaceCindersValue,
        Optional<DescriptionOfRoadSurfaceRock> descriptionOfRoadSurfaceRockValue,
        Optional<DescriptionOfRoadSurfaceIce> descriptionOfRoadSurfaceIceValue,
        Optional<DescriptionOfRoadSurfaceSnow> descriptionOfRoadSurfaceSnowValue)
    {
        _descriptionOfRoadSurfacePortlandCementValue = descriptionOfRoadSurfacePortlandCementValue;
        _descriptionOfRoadSurfaceAsphaltOrTarValue = descriptionOfRoadSurfaceAsphaltOrTarValue;
        _descriptionOfRoadSurfaceGravelValue = descriptionOfRoadSurfaceGravelValue;
        _descriptionOfRoadSurfaceGrassValue = descriptionOfRoadSurfaceGrassValue;
        _descriptionOfRoadSurfaceCindersValue = descriptionOfRoadSurfaceCindersValue;
        _descriptionOfRoadSurfaceRockValue = descriptionOfRoadSurfaceRockValue;
        _descriptionOfRoadSurfaceIceValue = descriptionOfRoadSurfaceIceValue;
        _descriptionOfRoadSurfaceSnowValue = descriptionOfRoadSurfaceSnowValue;
    }

    public static DescriptionOfRoadSurface DescriptionOfRoadSurfacePortlandCement(DescriptionOfRoadSurfacePortlandCement value) =>
        new(Optional<DescriptionOfRoadSurfacePortlandCement>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static DescriptionOfRoadSurface DescriptionOfRoadSurfaceAsphaltOrTar(DescriptionOfRoadSurfaceAsphaltOrTar value) =>
        new(default,
            Optional<DescriptionOfRoadSurfaceAsphaltOrTar>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    public static DescriptionOfRoadSurface DescriptionOfRoadSurfaceGravel(DescriptionOfRoadSurfaceGravel value) =>
        new(default,
            default,
            Optional<DescriptionOfRoadSurfaceGravel>.Some(value),
            default,
            default,
            default,
            default,
            default);

    public static DescriptionOfRoadSurface DescriptionOfRoadSurfaceGrass(DescriptionOfRoadSurfaceGrass value) =>
        new(default,
            default,
            default,
            Optional<DescriptionOfRoadSurfaceGrass>.Some(value),
            default,
            default,
            default,
            default);

    public static DescriptionOfRoadSurface DescriptionOfRoadSurfaceCinders(DescriptionOfRoadSurfaceCinders value) =>
        new(default,
            default,
            default,
            default,
            Optional<DescriptionOfRoadSurfaceCinders>.Some(value),
            default,
            default,
            default);

    public static DescriptionOfRoadSurface DescriptionOfRoadSurfaceRock(DescriptionOfRoadSurfaceRock value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<DescriptionOfRoadSurfaceRock>.Some(value),
            default,
            default);

    public static DescriptionOfRoadSurface DescriptionOfRoadSurfaceIce(DescriptionOfRoadSurfaceIce value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            Optional<DescriptionOfRoadSurfaceIce>.Some(value),
            default);

    public static DescriptionOfRoadSurface DescriptionOfRoadSurfaceSnow(DescriptionOfRoadSurfaceSnow value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<DescriptionOfRoadSurfaceSnow>.Some(value));

    public bool TryGetDescriptionOfRoadSurfacePortlandCement(out DescriptionOfRoadSurfacePortlandCement value) =>
        _descriptionOfRoadSurfacePortlandCementValue.TryGetValue(out value);

    public bool TryGetDescriptionOfRoadSurfaceAsphaltOrTar(out DescriptionOfRoadSurfaceAsphaltOrTar value) =>
        _descriptionOfRoadSurfaceAsphaltOrTarValue.TryGetValue(out value);

    public bool TryGetDescriptionOfRoadSurfaceGravel(out DescriptionOfRoadSurfaceGravel value) =>
        _descriptionOfRoadSurfaceGravelValue.TryGetValue(out value);

    public bool TryGetDescriptionOfRoadSurfaceGrass(out DescriptionOfRoadSurfaceGrass value) =>
        _descriptionOfRoadSurfaceGrassValue.TryGetValue(out value);

    public bool TryGetDescriptionOfRoadSurfaceCinders(out DescriptionOfRoadSurfaceCinders value) =>
        _descriptionOfRoadSurfaceCindersValue.TryGetValue(out value);

    public bool TryGetDescriptionOfRoadSurfaceRock(out DescriptionOfRoadSurfaceRock value) =>
        _descriptionOfRoadSurfaceRockValue.TryGetValue(out value);

    public bool TryGetDescriptionOfRoadSurfaceIce(out DescriptionOfRoadSurfaceIce value) =>
        _descriptionOfRoadSurfaceIceValue.TryGetValue(out value);

    public bool TryGetDescriptionOfRoadSurfaceSnow(out DescriptionOfRoadSurfaceSnow value) =>
        _descriptionOfRoadSurfaceSnowValue.TryGetValue(out value);

    public static implicit operator DescriptionOfRoadSurface(DescriptionOfRoadSurfacePortlandCement value) =>
        DescriptionOfRoadSurfacePortlandCement(value);

    public static implicit operator DescriptionOfRoadSurface(DescriptionOfRoadSurfaceAsphaltOrTar value) =>
        DescriptionOfRoadSurfaceAsphaltOrTar(value);

    public static implicit operator DescriptionOfRoadSurface(DescriptionOfRoadSurfaceGravel value) =>
        DescriptionOfRoadSurfaceGravel(value);

    public static implicit operator DescriptionOfRoadSurface(DescriptionOfRoadSurfaceGrass value) =>
        DescriptionOfRoadSurfaceGrass(value);

    public static implicit operator DescriptionOfRoadSurface(DescriptionOfRoadSurfaceCinders value) =>
        DescriptionOfRoadSurfaceCinders(value);

    public static implicit operator DescriptionOfRoadSurface(DescriptionOfRoadSurfaceRock value) =>
        DescriptionOfRoadSurfaceRock(value);

    public static implicit operator DescriptionOfRoadSurface(DescriptionOfRoadSurfaceIce value) =>
        DescriptionOfRoadSurfaceIce(value);

    public static implicit operator DescriptionOfRoadSurface(DescriptionOfRoadSurfaceSnow value) =>
        DescriptionOfRoadSurfaceSnow(value);
}

file sealed class DescriptionOfRoadSurfaceConverter : JsonConverter<DescriptionOfRoadSurface>
{
    public override DescriptionOfRoadSurface Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<DescriptionOfRoadSurfacePortlandCement>(root,
            options,
            out var descriptionOfRoadSurfacePortlandCementValue))
        {
            return DescriptionOfRoadSurface.DescriptionOfRoadSurfacePortlandCement(descriptionOfRoadSurfacePortlandCementValue);
        }
        if (JsonSerializer.TryDeserialize<DescriptionOfRoadSurfaceAsphaltOrTar>(root,
            options,
            out var descriptionOfRoadSurfaceAsphaltOrTarValue))
        {
            return DescriptionOfRoadSurface.DescriptionOfRoadSurfaceAsphaltOrTar(descriptionOfRoadSurfaceAsphaltOrTarValue);
        }
        if (JsonSerializer.TryDeserialize<DescriptionOfRoadSurfaceGravel>(root,
            options,
            out var descriptionOfRoadSurfaceGravelValue))
        {
            return DescriptionOfRoadSurface.DescriptionOfRoadSurfaceGravel(descriptionOfRoadSurfaceGravelValue);
        }
        if (JsonSerializer.TryDeserialize<DescriptionOfRoadSurfaceGrass>(root,
            options,
            out var descriptionOfRoadSurfaceGrassValue))
        {
            return DescriptionOfRoadSurface.DescriptionOfRoadSurfaceGrass(descriptionOfRoadSurfaceGrassValue);
        }
        if (JsonSerializer.TryDeserialize<DescriptionOfRoadSurfaceCinders>(root,
            options,
            out var descriptionOfRoadSurfaceCindersValue))
        {
            return DescriptionOfRoadSurface.DescriptionOfRoadSurfaceCinders(descriptionOfRoadSurfaceCindersValue);
        }
        if (JsonSerializer.TryDeserialize<DescriptionOfRoadSurfaceRock>(root,
            options,
            out var descriptionOfRoadSurfaceRockValue))
        {
            return DescriptionOfRoadSurface.DescriptionOfRoadSurfaceRock(descriptionOfRoadSurfaceRockValue);
        }
        if (JsonSerializer.TryDeserialize<DescriptionOfRoadSurfaceIce>(root,
            options,
            out var descriptionOfRoadSurfaceIceValue))
        {
            return DescriptionOfRoadSurface.DescriptionOfRoadSurfaceIce(descriptionOfRoadSurfaceIceValue);
        }
        if (JsonSerializer.TryDeserialize<DescriptionOfRoadSurfaceSnow>(root,
            options,
            out var descriptionOfRoadSurfaceSnowValue))
        {
            return DescriptionOfRoadSurface.DescriptionOfRoadSurfaceSnow(descriptionOfRoadSurfaceSnowValue);
        }
        throw new JsonException($"JSON does not match DescriptionOfRoadSurfacePortlandCement or DescriptionOfRoadSurfaceAsphaltOrTar or DescriptionOfRoadSurfaceGravel or DescriptionOfRoadSurfaceGrass or DescriptionOfRoadSurfaceCinders or DescriptionOfRoadSurfaceRock or DescriptionOfRoadSurfaceIce or DescriptionOfRoadSurfaceSnow schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, DescriptionOfRoadSurface value, JsonSerializerOptions options)
    {
        if (value.TryGetDescriptionOfRoadSurfacePortlandCement(out var descriptionOfRoadSurfacePortlandCementValue))
        {
            JsonSerializer.Serialize(writer, descriptionOfRoadSurfacePortlandCementValue, options);
        }
        else if (value.TryGetDescriptionOfRoadSurfaceAsphaltOrTar(out var descriptionOfRoadSurfaceAsphaltOrTarValue))
        {
            JsonSerializer.Serialize(writer, descriptionOfRoadSurfaceAsphaltOrTarValue, options);
        }
        else if (value.TryGetDescriptionOfRoadSurfaceGravel(out var descriptionOfRoadSurfaceGravelValue))
        {
            JsonSerializer.Serialize(writer, descriptionOfRoadSurfaceGravelValue, options);
        }
        else if (value.TryGetDescriptionOfRoadSurfaceGrass(out var descriptionOfRoadSurfaceGrassValue))
        {
            JsonSerializer.Serialize(writer, descriptionOfRoadSurfaceGrassValue, options);
        }
        else if (value.TryGetDescriptionOfRoadSurfaceCinders(out var descriptionOfRoadSurfaceCindersValue))
        {
            JsonSerializer.Serialize(writer, descriptionOfRoadSurfaceCindersValue, options);
        }
        else if (value.TryGetDescriptionOfRoadSurfaceRock(out var descriptionOfRoadSurfaceRockValue))
        {
            JsonSerializer.Serialize(writer, descriptionOfRoadSurfaceRockValue, options);
        }
        else if (value.TryGetDescriptionOfRoadSurfaceIce(out var descriptionOfRoadSurfaceIceValue))
        {
            JsonSerializer.Serialize(writer, descriptionOfRoadSurfaceIceValue, options);
        }
        else if (value.TryGetDescriptionOfRoadSurfaceSnow(out var descriptionOfRoadSurfaceSnowValue))
        {
            JsonSerializer.Serialize(writer, descriptionOfRoadSurfaceSnowValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(DescriptionOfRoadSurface)} contains no valid value to serialize.");
        }
    }
}
