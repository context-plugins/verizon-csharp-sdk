using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(AccountGroupShareThresholdConverter))]
public record AccountGroupShareThreshold
{
    private readonly Optional<Carriercode1> _carriercode1Value;

    private AccountGroupShareThreshold(Optional<Carriercode1> carriercode1Value)
    {
        _carriercode1Value = carriercode1Value;
    }

    public static AccountGroupShareThreshold Carriercode1(Carriercode1 value) =>
        new(Optional<Carriercode1>.Some(value));

    public bool TryGetCarriercode1(out Carriercode1 value) => _carriercode1Value.TryGetValue(out value);

    public static implicit operator AccountGroupShareThreshold(Carriercode1 value) => Carriercode1(value);
}

file sealed class AccountGroupShareThresholdConverter : JsonConverter<AccountGroupShareThreshold>
{
    public override AccountGroupShareThreshold Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<Carriercode1>(root, options, out var carriercode1Value))
        {
            return AccountGroupShareThreshold.Carriercode1(carriercode1Value);
        }
        throw new JsonException($"JSON does not match Carriercode1 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        AccountGroupShareThreshold value,
        JsonSerializerOptions options)
    {
        if (value.TryGetCarriercode1(out var carriercode1Value))
        {
            JsonSerializer.Serialize(writer, carriercode1Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(AccountGroupShareThreshold)} contains no valid value to serialize.");
        }
    }
}
