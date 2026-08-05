using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(PrimaryPlaceOfUse1Converter))]
public record PrimaryPlaceOfUse1
{
    private readonly Optional<Customernamequery> _customernamequeryValue;

    private readonly Optional<Addressquery> _addressqueryValue;

    private PrimaryPlaceOfUse1(Optional<Customernamequery> customernamequeryValue,
        Optional<Addressquery> addressqueryValue)
    {
        _customernamequeryValue = customernamequeryValue;
        _addressqueryValue = addressqueryValue;
    }

    public static PrimaryPlaceOfUse1 Customernamequery(Customernamequery value) =>
        new(Optional<Customernamequery>.Some(value), default);

    public static PrimaryPlaceOfUse1 Addressquery(Addressquery value) =>
        new(default, Optional<Addressquery>.Some(value));

    public bool TryGetCustomernamequery(out Customernamequery value) =>
        _customernamequeryValue.TryGetValue(out value);

    public bool TryGetAddressquery(out Addressquery value) => _addressqueryValue.TryGetValue(out value);

    public static implicit operator PrimaryPlaceOfUse1(Customernamequery value) => Customernamequery(value);

    public static implicit operator PrimaryPlaceOfUse1(Addressquery value) => Addressquery(value);
}

file sealed class PrimaryPlaceOfUse1Converter : JsonConverter<PrimaryPlaceOfUse1>
{
    public override PrimaryPlaceOfUse1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<Customernamequery>(root, options, out var customernamequeryValue))
        {
            return PrimaryPlaceOfUse1.Customernamequery(customernamequeryValue);
        }
        if (JsonSerializer.TryDeserialize<Addressquery>(root, options, out var addressqueryValue))
        {
            return PrimaryPlaceOfUse1.Addressquery(addressqueryValue);
        }
        throw new JsonException($"JSON does not match Customernamequery or Addressquery schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, PrimaryPlaceOfUse1 value, JsonSerializerOptions options)
    {
        if (value.TryGetCustomernamequery(out var customernamequeryValue))
        {
            JsonSerializer.Serialize(writer, customernamequeryValue, options);
        }
        else if (value.TryGetAddressquery(out var addressqueryValue))
        {
            JsonSerializer.Serialize(writer, addressqueryValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(PrimaryPlaceOfUse1)} contains no valid value to serialize.");
        }
    }
}
