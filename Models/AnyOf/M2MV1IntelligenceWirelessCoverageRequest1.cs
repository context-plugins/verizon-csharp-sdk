using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(M2MV1IntelligenceWirelessCoverageRequest1Converter))]
public record M2MV1IntelligenceWirelessCoverageRequest1
{
    private readonly Optional<GetWirelessCoverageRequest> _getWirelessCoverageRequestValue;

    private readonly Optional<GetWirelessCoverageRequestFwa> _getWirelessCoverageRequestFwaValue;

    private M2MV1IntelligenceWirelessCoverageRequest1(Optional<GetWirelessCoverageRequest> getWirelessCoverageRequestValue,
        Optional<GetWirelessCoverageRequestFwa> getWirelessCoverageRequestFwaValue)
    {
        _getWirelessCoverageRequestValue = getWirelessCoverageRequestValue;
        _getWirelessCoverageRequestFwaValue = getWirelessCoverageRequestFwaValue;
    }

    public static M2MV1IntelligenceWirelessCoverageRequest1 GetWirelessCoverageRequest(GetWirelessCoverageRequest value) =>
        new(Optional<GetWirelessCoverageRequest>.Some(value), default);

    public static M2MV1IntelligenceWirelessCoverageRequest1 GetWirelessCoverageRequestFwa(GetWirelessCoverageRequestFwa value) =>
        new(default, Optional<GetWirelessCoverageRequestFwa>.Some(value));

    public bool TryGetGetWirelessCoverageRequest(out GetWirelessCoverageRequest value) =>
        _getWirelessCoverageRequestValue.TryGetValue(out value);

    public bool TryGetGetWirelessCoverageRequestFwa(out GetWirelessCoverageRequestFwa value) =>
        _getWirelessCoverageRequestFwaValue.TryGetValue(out value);

    public static implicit operator M2MV1IntelligenceWirelessCoverageRequest1(GetWirelessCoverageRequest value) =>
        GetWirelessCoverageRequest(value);

    public static implicit operator M2MV1IntelligenceWirelessCoverageRequest1(GetWirelessCoverageRequestFwa value) =>
        GetWirelessCoverageRequestFwa(value);
}

file sealed class M2MV1IntelligenceWirelessCoverageRequest1Converter : JsonConverter<M2MV1IntelligenceWirelessCoverageRequest1>
{
    public override M2MV1IntelligenceWirelessCoverageRequest1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<GetWirelessCoverageRequest>(root,
            options,
            out var getWirelessCoverageRequestValue))
        {
            return M2MV1IntelligenceWirelessCoverageRequest1.GetWirelessCoverageRequest(getWirelessCoverageRequestValue);
        }
        if (JsonSerializer.TryDeserialize<GetWirelessCoverageRequestFwa>(root,
            options,
            out var getWirelessCoverageRequestFwaValue))
        {
            return M2MV1IntelligenceWirelessCoverageRequest1.GetWirelessCoverageRequestFwa(getWirelessCoverageRequestFwaValue);
        }
        throw new JsonException($"JSON does not match GetWirelessCoverageRequest or GetWirelessCoverageRequestFwa schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        M2MV1IntelligenceWirelessCoverageRequest1 value,
        JsonSerializerOptions options)
    {
        if (value.TryGetGetWirelessCoverageRequest(out var getWirelessCoverageRequestValue))
        {
            JsonSerializer.Serialize(writer, getWirelessCoverageRequestValue, options);
        }
        else if (value.TryGetGetWirelessCoverageRequestFwa(out var getWirelessCoverageRequestFwaValue))
        {
            JsonSerializer.Serialize(writer, getWirelessCoverageRequestFwaValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(M2MV1IntelligenceWirelessCoverageRequest1)} contains no valid value to serialize.");
        }
    }
}
