using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

/// <summary>
/// The main cause of a detected event. Each entry is of a different type and represents the sub cause code.
/// </summary>
[JsonConverter(typeof(CauseCodeChoiceConverter))]
public record CauseCodeChoice
{
    private readonly Optional<TrafficConditionCauseCode> _trafficConditionCauseCodeValue;

    private readonly Optional<AccidentCauseCode> _accidentCauseCodeValue;

    private readonly Optional<RoadworksCauseCode> _roadworksCauseCodeValue;

    private readonly Optional<ImpassabilityCauseCode> _impassabilityCauseCodeValue;

    private readonly Optional<WrongWayDrivingCauseCode> _wrongWayDrivingCauseCodeValue;

    private readonly Optional<EmergencyVehicleApproachingCauseCode> _emergencyVehicleApproachingCauseCodeValue;

    private CauseCodeChoice(Optional<TrafficConditionCauseCode> trafficConditionCauseCodeValue,
        Optional<AccidentCauseCode> accidentCauseCodeValue,
        Optional<RoadworksCauseCode> roadworksCauseCodeValue,
        Optional<ImpassabilityCauseCode> impassabilityCauseCodeValue,
        Optional<WrongWayDrivingCauseCode> wrongWayDrivingCauseCodeValue,
        Optional<EmergencyVehicleApproachingCauseCode> emergencyVehicleApproachingCauseCodeValue)
    {
        _trafficConditionCauseCodeValue = trafficConditionCauseCodeValue;
        _accidentCauseCodeValue = accidentCauseCodeValue;
        _roadworksCauseCodeValue = roadworksCauseCodeValue;
        _impassabilityCauseCodeValue = impassabilityCauseCodeValue;
        _wrongWayDrivingCauseCodeValue = wrongWayDrivingCauseCodeValue;
        _emergencyVehicleApproachingCauseCodeValue = emergencyVehicleApproachingCauseCodeValue;
    }

    public static CauseCodeChoice TrafficConditionCauseCode(TrafficConditionCauseCode value) =>
        new(Optional<TrafficConditionCauseCode>.Some(value), default, default, default, default, default);

    public static CauseCodeChoice AccidentCauseCode(AccidentCauseCode value) =>
        new(default, Optional<AccidentCauseCode>.Some(value), default, default, default, default);

    public static CauseCodeChoice RoadworksCauseCode(RoadworksCauseCode value) =>
        new(default, default, Optional<RoadworksCauseCode>.Some(value), default, default, default);

    public static CauseCodeChoice ImpassabilityCauseCode(ImpassabilityCauseCode value) =>
        new(default, default, default, Optional<ImpassabilityCauseCode>.Some(value), default, default);

    public static CauseCodeChoice WrongWayDrivingCauseCode(WrongWayDrivingCauseCode value) =>
        new(default, default, default, default, Optional<WrongWayDrivingCauseCode>.Some(value), default);

    public static CauseCodeChoice EmergencyVehicleApproachingCauseCode(EmergencyVehicleApproachingCauseCode value) =>
        new(default, default, default, default, default, Optional<EmergencyVehicleApproachingCauseCode>.Some(value));

    public bool TryGetTrafficConditionCauseCode(out TrafficConditionCauseCode value) =>
        _trafficConditionCauseCodeValue.TryGetValue(out value);

    public bool TryGetAccidentCauseCode(out AccidentCauseCode value) =>
        _accidentCauseCodeValue.TryGetValue(out value);

    public bool TryGetRoadworksCauseCode(out RoadworksCauseCode value) =>
        _roadworksCauseCodeValue.TryGetValue(out value);

    public bool TryGetImpassabilityCauseCode(out ImpassabilityCauseCode value) =>
        _impassabilityCauseCodeValue.TryGetValue(out value);

    public bool TryGetWrongWayDrivingCauseCode(out WrongWayDrivingCauseCode value) =>
        _wrongWayDrivingCauseCodeValue.TryGetValue(out value);

    public bool TryGetEmergencyVehicleApproachingCauseCode(out EmergencyVehicleApproachingCauseCode value) =>
        _emergencyVehicleApproachingCauseCodeValue.TryGetValue(out value);

    public static implicit operator CauseCodeChoice(TrafficConditionCauseCode value) =>
        TrafficConditionCauseCode(value);

    public static implicit operator CauseCodeChoice(AccidentCauseCode value) => AccidentCauseCode(value);

    public static implicit operator CauseCodeChoice(RoadworksCauseCode value) => RoadworksCauseCode(value);

    public static implicit operator CauseCodeChoice(ImpassabilityCauseCode value) =>
        ImpassabilityCauseCode(value);

    public static implicit operator CauseCodeChoice(WrongWayDrivingCauseCode value) =>
        WrongWayDrivingCauseCode(value);

    public static implicit operator CauseCodeChoice(EmergencyVehicleApproachingCauseCode value) =>
        EmergencyVehicleApproachingCauseCode(value);
}

file sealed class CauseCodeChoiceConverter : JsonConverter<CauseCodeChoice>
{
    public override CauseCodeChoice Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<TrafficConditionCauseCode>(root,
            options,
            out var trafficConditionCauseCodeValue))
        {
            return CauseCodeChoice.TrafficConditionCauseCode(trafficConditionCauseCodeValue);
        }
        if (JsonSerializer.TryDeserialize<AccidentCauseCode>(root, options, out var accidentCauseCodeValue))
        {
            return CauseCodeChoice.AccidentCauseCode(accidentCauseCodeValue);
        }
        if (JsonSerializer.TryDeserialize<RoadworksCauseCode>(root, options, out var roadworksCauseCodeValue))
        {
            return CauseCodeChoice.RoadworksCauseCode(roadworksCauseCodeValue);
        }
        if (JsonSerializer.TryDeserialize<ImpassabilityCauseCode>(root,
            options,
            out var impassabilityCauseCodeValue))
        {
            return CauseCodeChoice.ImpassabilityCauseCode(impassabilityCauseCodeValue);
        }
        if (JsonSerializer.TryDeserialize<WrongWayDrivingCauseCode>(root,
            options,
            out var wrongWayDrivingCauseCodeValue))
        {
            return CauseCodeChoice.WrongWayDrivingCauseCode(wrongWayDrivingCauseCodeValue);
        }
        if (JsonSerializer.TryDeserialize<EmergencyVehicleApproachingCauseCode>(root,
            options,
            out var emergencyVehicleApproachingCauseCodeValue))
        {
            return CauseCodeChoice.EmergencyVehicleApproachingCauseCode(emergencyVehicleApproachingCauseCodeValue);
        }
        throw new JsonException($"JSON does not match TrafficConditionCauseCode or AccidentCauseCode or RoadworksCauseCode or ImpassabilityCauseCode or WrongWayDrivingCauseCode or EmergencyVehicleApproachingCauseCode schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, CauseCodeChoice value, JsonSerializerOptions options)
    {
        if (value.TryGetTrafficConditionCauseCode(out var trafficConditionCauseCodeValue))
        {
            JsonSerializer.Serialize(writer, trafficConditionCauseCodeValue, options);
        }
        else if (value.TryGetAccidentCauseCode(out var accidentCauseCodeValue))
        {
            JsonSerializer.Serialize(writer, accidentCauseCodeValue, options);
        }
        else if (value.TryGetRoadworksCauseCode(out var roadworksCauseCodeValue))
        {
            JsonSerializer.Serialize(writer, roadworksCauseCodeValue, options);
        }
        else if (value.TryGetImpassabilityCauseCode(out var impassabilityCauseCodeValue))
        {
            JsonSerializer.Serialize(writer, impassabilityCauseCodeValue, options);
        }
        else if (value.TryGetWrongWayDrivingCauseCode(out var wrongWayDrivingCauseCodeValue))
        {
            JsonSerializer.Serialize(writer, wrongWayDrivingCauseCodeValue, options);
        }
        else if (value.TryGetEmergencyVehicleApproachingCauseCode(out var emergencyVehicleApproachingCauseCodeValue))
        {
            JsonSerializer.Serialize(writer, emergencyVehicleApproachingCauseCodeValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(CauseCodeChoice)} contains no valid value to serialize.");
        }
    }
}
