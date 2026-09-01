using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(V2TriggersRequestConverter))]
public record V2TriggersRequest
{
    private readonly Optional<AccountLevelCreateTriggerRequest> _accountLevelCreateTriggerRequestValue;

    private readonly Optional<AccountLevelObject> _accountLevelObjectValue;

    private readonly Optional<DeviceLevelCreateTriggerRequest> _deviceLevelCreateTriggerRequestValue;

    private readonly Optional<AccountGroupShareCreateTriggerRequest> _accountGroupShareCreateTriggerRequestValue;

    private readonly Optional<AccountShareCreateTriggerRequest> _accountShareCreateTriggerRequestValue;

    private readonly Optional<PayAsYouGoCreateTriggerRequest> _payAsYouGoCreateTriggerRequestValue;

    private readonly Optional<Createtriggerchunk> _createtriggerchunkValue;

    private V2TriggersRequest(Optional<AccountLevelCreateTriggerRequest> accountLevelCreateTriggerRequestValue,
        Optional<AccountLevelObject> accountLevelObjectValue,
        Optional<DeviceLevelCreateTriggerRequest> deviceLevelCreateTriggerRequestValue,
        Optional<AccountGroupShareCreateTriggerRequest> accountGroupShareCreateTriggerRequestValue,
        Optional<AccountShareCreateTriggerRequest> accountShareCreateTriggerRequestValue,
        Optional<PayAsYouGoCreateTriggerRequest> payAsYouGoCreateTriggerRequestValue,
        Optional<Createtriggerchunk> createtriggerchunkValue)
    {
        _accountLevelCreateTriggerRequestValue = accountLevelCreateTriggerRequestValue;
        _accountLevelObjectValue = accountLevelObjectValue;
        _deviceLevelCreateTriggerRequestValue = deviceLevelCreateTriggerRequestValue;
        _accountGroupShareCreateTriggerRequestValue = accountGroupShareCreateTriggerRequestValue;
        _accountShareCreateTriggerRequestValue = accountShareCreateTriggerRequestValue;
        _payAsYouGoCreateTriggerRequestValue = payAsYouGoCreateTriggerRequestValue;
        _createtriggerchunkValue = createtriggerchunkValue;
    }

    public static V2TriggersRequest AccountLevelCreateTriggerRequest(AccountLevelCreateTriggerRequest value) =>
        new(Optional<AccountLevelCreateTriggerRequest>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    public static V2TriggersRequest AccountLevelObject(AccountLevelObject value) =>
        new(default, Optional<AccountLevelObject>.Some(value), default, default, default, default, default);

    public static V2TriggersRequest DeviceLevelCreateTriggerRequest(DeviceLevelCreateTriggerRequest value) =>
        new(default, default, Optional<DeviceLevelCreateTriggerRequest>.Some(value), default, default, default, default);

    public static V2TriggersRequest AccountGroupShareCreateTriggerRequest(AccountGroupShareCreateTriggerRequest value) =>
        new(default,
            default,
            default,
            Optional<AccountGroupShareCreateTriggerRequest>.Some(value),
            default,
            default,
            default);

    public static V2TriggersRequest AccountShareCreateTriggerRequest(AccountShareCreateTriggerRequest value) =>
        new(default,
            default,
            default,
            default,
            Optional<AccountShareCreateTriggerRequest>.Some(value),
            default,
            default);

    public static V2TriggersRequest PayAsYouGoCreateTriggerRequest(PayAsYouGoCreateTriggerRequest value) =>
        new(default, default, default, default, default, Optional<PayAsYouGoCreateTriggerRequest>.Some(value), default);

    public static V2TriggersRequest Createtriggerchunk(Createtriggerchunk value) =>
        new(default, default, default, default, default, default, Optional<Createtriggerchunk>.Some(value));

    public bool TryGetAccountLevelCreateTriggerRequest(out AccountLevelCreateTriggerRequest value) =>
        _accountLevelCreateTriggerRequestValue.TryGetValue(out value);

    public bool TryGetAccountLevelObject(out AccountLevelObject value) =>
        _accountLevelObjectValue.TryGetValue(out value);

    public bool TryGetDeviceLevelCreateTriggerRequest(out DeviceLevelCreateTriggerRequest value) =>
        _deviceLevelCreateTriggerRequestValue.TryGetValue(out value);

    public bool TryGetAccountGroupShareCreateTriggerRequest(out AccountGroupShareCreateTriggerRequest value) =>
        _accountGroupShareCreateTriggerRequestValue.TryGetValue(out value);

    public bool TryGetAccountShareCreateTriggerRequest(out AccountShareCreateTriggerRequest value) =>
        _accountShareCreateTriggerRequestValue.TryGetValue(out value);

    public bool TryGetPayAsYouGoCreateTriggerRequest(out PayAsYouGoCreateTriggerRequest value) =>
        _payAsYouGoCreateTriggerRequestValue.TryGetValue(out value);

    public bool TryGetCreatetriggerchunk(out Createtriggerchunk value) =>
        _createtriggerchunkValue.TryGetValue(out value);

    public static implicit operator V2TriggersRequest(AccountLevelCreateTriggerRequest value) =>
        AccountLevelCreateTriggerRequest(value);

    public static implicit operator V2TriggersRequest(AccountLevelObject value) => AccountLevelObject(value);

    public static implicit operator V2TriggersRequest(DeviceLevelCreateTriggerRequest value) =>
        DeviceLevelCreateTriggerRequest(value);

    public static implicit operator V2TriggersRequest(AccountGroupShareCreateTriggerRequest value) =>
        AccountGroupShareCreateTriggerRequest(value);

    public static implicit operator V2TriggersRequest(AccountShareCreateTriggerRequest value) =>
        AccountShareCreateTriggerRequest(value);

    public static implicit operator V2TriggersRequest(PayAsYouGoCreateTriggerRequest value) =>
        PayAsYouGoCreateTriggerRequest(value);

    public static implicit operator V2TriggersRequest(Createtriggerchunk value) => Createtriggerchunk(value);
}

file sealed class V2TriggersRequestConverter : JsonConverter<V2TriggersRequest>
{
    public override V2TriggersRequest Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<AccountLevelCreateTriggerRequest>(root,
            options,
            out var accountLevelCreateTriggerRequestValue))
        {
            return V2TriggersRequest.AccountLevelCreateTriggerRequest(accountLevelCreateTriggerRequestValue);
        }
        if (JsonSerializer.TryDeserialize<AccountLevelObject>(root, options, out var accountLevelObjectValue))
        {
            return V2TriggersRequest.AccountLevelObject(accountLevelObjectValue);
        }
        if (JsonSerializer.TryDeserialize<DeviceLevelCreateTriggerRequest>(root,
            options,
            out var deviceLevelCreateTriggerRequestValue))
        {
            return V2TriggersRequest.DeviceLevelCreateTriggerRequest(deviceLevelCreateTriggerRequestValue);
        }
        if (JsonSerializer.TryDeserialize<AccountGroupShareCreateTriggerRequest>(root,
            options,
            out var accountGroupShareCreateTriggerRequestValue))
        {
            return V2TriggersRequest.AccountGroupShareCreateTriggerRequest(accountGroupShareCreateTriggerRequestValue);
        }
        if (JsonSerializer.TryDeserialize<AccountShareCreateTriggerRequest>(root,
            options,
            out var accountShareCreateTriggerRequestValue))
        {
            return V2TriggersRequest.AccountShareCreateTriggerRequest(accountShareCreateTriggerRequestValue);
        }
        if (JsonSerializer.TryDeserialize<PayAsYouGoCreateTriggerRequest>(root,
            options,
            out var payAsYouGoCreateTriggerRequestValue))
        {
            return V2TriggersRequest.PayAsYouGoCreateTriggerRequest(payAsYouGoCreateTriggerRequestValue);
        }
        if (JsonSerializer.TryDeserialize<Createtriggerchunk>(root, options, out var createtriggerchunkValue))
        {
            return V2TriggersRequest.Createtriggerchunk(createtriggerchunkValue);
        }
        throw new JsonException($"JSON does not match AccountLevelCreateTriggerRequest or AccountLevelObject or DeviceLevelCreateTriggerRequest or AccountGroupShareCreateTriggerRequest or AccountShareCreateTriggerRequest or PayAsYouGoCreateTriggerRequest or Createtriggerchunk schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, V2TriggersRequest value, JsonSerializerOptions options)
    {
        if (value.TryGetAccountLevelCreateTriggerRequest(out var accountLevelCreateTriggerRequestValue))
        {
            JsonSerializer.Serialize(writer, accountLevelCreateTriggerRequestValue, options);
        }
        else if (value.TryGetAccountLevelObject(out var accountLevelObjectValue))
        {
            JsonSerializer.Serialize(writer, accountLevelObjectValue, options);
        }
        else if (value.TryGetDeviceLevelCreateTriggerRequest(out var deviceLevelCreateTriggerRequestValue))
        {
            JsonSerializer.Serialize(writer, deviceLevelCreateTriggerRequestValue, options);
        }
        else if (value.TryGetAccountGroupShareCreateTriggerRequest(out var accountGroupShareCreateTriggerRequestValue))
        {
            JsonSerializer.Serialize(writer, accountGroupShareCreateTriggerRequestValue, options);
        }
        else if (value.TryGetAccountShareCreateTriggerRequest(out var accountShareCreateTriggerRequestValue))
        {
            JsonSerializer.Serialize(writer, accountShareCreateTriggerRequestValue, options);
        }
        else if (value.TryGetPayAsYouGoCreateTriggerRequest(out var payAsYouGoCreateTriggerRequestValue))
        {
            JsonSerializer.Serialize(writer, payAsYouGoCreateTriggerRequestValue, options);
        }
        else if (value.TryGetCreatetriggerchunk(out var createtriggerchunkValue))
        {
            JsonSerializer.Serialize(writer, createtriggerchunkValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(V2TriggersRequest)} contains no valid value to serialize.");
        }
    }
}
