using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(PrimaryPlaceOfUseConverter))]
public record PrimaryPlaceOfUse
{
    private readonly Optional<Customernamequery> _customernamequeryValue;

    private readonly Optional<Addressquery> _addressqueryValue;

    private PrimaryPlaceOfUse(Optional<Customernamequery> customernamequeryValue,
        Optional<Addressquery> addressqueryValue)
    {
        _customernamequeryValue = customernamequeryValue;
        _addressqueryValue = addressqueryValue;
    }

    public static PrimaryPlaceOfUse Customernamequery(Customernamequery value) =>
        new(Optional<Customernamequery>.Some(value), default);

    public static PrimaryPlaceOfUse Addressquery(Addressquery value) =>
        new(default, Optional<Addressquery>.Some(value));

    public bool TryGetCustomernamequery(out Customernamequery value) =>
        _customernamequeryValue.TryGetValue(out value);

    public bool TryGetAddressquery(out Addressquery value) => _addressqueryValue.TryGetValue(out value);

    public static implicit operator PrimaryPlaceOfUse(Customernamequery value) => Customernamequery(value);

    public static implicit operator PrimaryPlaceOfUse(Addressquery value) => Addressquery(value);
}

file sealed class PrimaryPlaceOfUseConverter : JsonConverter<PrimaryPlaceOfUse>
{
    public override PrimaryPlaceOfUse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<Customernamequery>(root, options, out var customernamequeryValue))
        {
            return PrimaryPlaceOfUse.Customernamequery(customernamequeryValue);
        }
        if (JsonSerializer.TryDeserialize<Addressquery>(root, options, out var addressqueryValue))
        {
            return PrimaryPlaceOfUse.Addressquery(addressqueryValue);
        }
        throw new JsonException($"JSON does not match Customernamequery or Addressquery schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, PrimaryPlaceOfUse value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(PrimaryPlaceOfUse)} contains no valid value to serialize.");
        }
    }
}
