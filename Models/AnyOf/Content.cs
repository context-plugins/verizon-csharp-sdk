using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(ContentConverter))]
public record Content
{
    private readonly Optional<AdvisoryContent> _advisoryContentValue;

    private readonly Optional<WorkZoneContent> _workZoneContentValue;

    private readonly Optional<GenericSignContent> _genericSignContentValue;

    private readonly Optional<SpeedLimitContent> _speedLimitContentValue;

    private readonly Optional<ExitServiceContent> _exitServiceContentValue;

    private Content(Optional<AdvisoryContent> advisoryContentValue,
        Optional<WorkZoneContent> workZoneContentValue,
        Optional<GenericSignContent> genericSignContentValue,
        Optional<SpeedLimitContent> speedLimitContentValue,
        Optional<ExitServiceContent> exitServiceContentValue)
    {
        _advisoryContentValue = advisoryContentValue;
        _workZoneContentValue = workZoneContentValue;
        _genericSignContentValue = genericSignContentValue;
        _speedLimitContentValue = speedLimitContentValue;
        _exitServiceContentValue = exitServiceContentValue;
    }

    public static Content AdvisoryContent(AdvisoryContent value) =>
        new(Optional<AdvisoryContent>.Some(value), default, default, default, default);

    public static Content WorkZoneContent(WorkZoneContent value) =>
        new(default, Optional<WorkZoneContent>.Some(value), default, default, default);

    public static Content GenericSignContent(GenericSignContent value) =>
        new(default, default, Optional<GenericSignContent>.Some(value), default, default);

    public static Content SpeedLimitContent(SpeedLimitContent value) =>
        new(default, default, default, Optional<SpeedLimitContent>.Some(value), default);

    public static Content ExitServiceContent(ExitServiceContent value) =>
        new(default, default, default, default, Optional<ExitServiceContent>.Some(value));

    public bool TryGetAdvisoryContent(out AdvisoryContent value) =>
        _advisoryContentValue.TryGetValue(out value);

    public bool TryGetWorkZoneContent(out WorkZoneContent value) =>
        _workZoneContentValue.TryGetValue(out value);

    public bool TryGetGenericSignContent(out GenericSignContent value) =>
        _genericSignContentValue.TryGetValue(out value);

    public bool TryGetSpeedLimitContent(out SpeedLimitContent value) =>
        _speedLimitContentValue.TryGetValue(out value);

    public bool TryGetExitServiceContent(out ExitServiceContent value) =>
        _exitServiceContentValue.TryGetValue(out value);

    public static implicit operator Content(AdvisoryContent value) => AdvisoryContent(value);

    public static implicit operator Content(WorkZoneContent value) => WorkZoneContent(value);

    public static implicit operator Content(GenericSignContent value) => GenericSignContent(value);

    public static implicit operator Content(SpeedLimitContent value) => SpeedLimitContent(value);

    public static implicit operator Content(ExitServiceContent value) => ExitServiceContent(value);
}

file sealed class ContentConverter : JsonConverter<Content>
{
    public override Content Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<AdvisoryContent>(root, options, out var advisoryContentValue))
        {
            return Content.AdvisoryContent(advisoryContentValue);
        }
        if (JsonSerializer.TryDeserialize<WorkZoneContent>(root, options, out var workZoneContentValue))
        {
            return Content.WorkZoneContent(workZoneContentValue);
        }
        if (JsonSerializer.TryDeserialize<GenericSignContent>(root, options, out var genericSignContentValue))
        {
            return Content.GenericSignContent(genericSignContentValue);
        }
        if (JsonSerializer.TryDeserialize<SpeedLimitContent>(root, options, out var speedLimitContentValue))
        {
            return Content.SpeedLimitContent(speedLimitContentValue);
        }
        if (JsonSerializer.TryDeserialize<ExitServiceContent>(root, options, out var exitServiceContentValue))
        {
            return Content.ExitServiceContent(exitServiceContentValue);
        }
        throw new JsonException($"JSON does not match AdvisoryContent or WorkZoneContent or GenericSignContent or SpeedLimitContent or ExitServiceContent schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Content value, JsonSerializerOptions options)
    {
        if (value.TryGetAdvisoryContent(out var advisoryContentValue))
        {
            JsonSerializer.Serialize(writer, advisoryContentValue, options);
        }
        else if (value.TryGetWorkZoneContent(out var workZoneContentValue))
        {
            JsonSerializer.Serialize(writer, workZoneContentValue, options);
        }
        else if (value.TryGetGenericSignContent(out var genericSignContentValue))
        {
            JsonSerializer.Serialize(writer, genericSignContentValue, options);
        }
        else if (value.TryGetSpeedLimitContent(out var speedLimitContentValue))
        {
            JsonSerializer.Serialize(writer, speedLimitContentValue, options);
        }
        else if (value.TryGetExitServiceContent(out var exitServiceContentValue))
        {
            JsonSerializer.Serialize(writer, exitServiceContentValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Content)} contains no valid value to serialize.");
        }
    }
}
