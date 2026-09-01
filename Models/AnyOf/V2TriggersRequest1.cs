using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(V2TriggersRequest1Converter))]
public record V2TriggersRequest1
{
    private readonly Optional<AccountLevelUpdateTriggerRequest> _accountLevelUpdateTriggerRequestValue;

    private readonly Optional<DeviceLevelUpdateTriggerRequest> _deviceLevelUpdateTriggerRequestValue;

    private readonly Optional<AccountGroupShareUpdateTriggerRequest> _accountGroupShareUpdateTriggerRequestValue;

    private readonly Optional<AccountShareUpdateTriggerRequest> _accountShareUpdateTriggerRequestValue;

    private readonly Optional<PayAsYouGoUpdateTriggerRequest> _payAsYouGoUpdateTriggerRequestValue;

    private readonly Optional<Updatetriggerchunk> _updatetriggerchunkValue;

    private V2TriggersRequest1(Optional<AccountLevelUpdateTriggerRequest> accountLevelUpdateTriggerRequestValue,
        Optional<DeviceLevelUpdateTriggerRequest> deviceLevelUpdateTriggerRequestValue,
        Optional<AccountGroupShareUpdateTriggerRequest> accountGroupShareUpdateTriggerRequestValue,
        Optional<AccountShareUpdateTriggerRequest> accountShareUpdateTriggerRequestValue,
        Optional<PayAsYouGoUpdateTriggerRequest> payAsYouGoUpdateTriggerRequestValue,
        Optional<Updatetriggerchunk> updatetriggerchunkValue)
    {
        _accountLevelUpdateTriggerRequestValue = accountLevelUpdateTriggerRequestValue;
        _deviceLevelUpdateTriggerRequestValue = deviceLevelUpdateTriggerRequestValue;
        _accountGroupShareUpdateTriggerRequestValue = accountGroupShareUpdateTriggerRequestValue;
        _accountShareUpdateTriggerRequestValue = accountShareUpdateTriggerRequestValue;
        _payAsYouGoUpdateTriggerRequestValue = payAsYouGoUpdateTriggerRequestValue;
        _updatetriggerchunkValue = updatetriggerchunkValue;
    }

    public static V2TriggersRequest1 AccountLevelUpdateTriggerRequest(AccountLevelUpdateTriggerRequest value) =>
        new(Optional<AccountLevelUpdateTriggerRequest>.Some(value), default, default, default, default, default);

    public static V2TriggersRequest1 DeviceLevelUpdateTriggerRequest(DeviceLevelUpdateTriggerRequest value) =>
        new(default, Optional<DeviceLevelUpdateTriggerRequest>.Some(value), default, default, default, default);

    public static V2TriggersRequest1 AccountGroupShareUpdateTriggerRequest(AccountGroupShareUpdateTriggerRequest value) =>
        new(default, default, Optional<AccountGroupShareUpdateTriggerRequest>.Some(value), default, default, default);

    public static V2TriggersRequest1 AccountShareUpdateTriggerRequest(AccountShareUpdateTriggerRequest value) =>
        new(default, default, default, Optional<AccountShareUpdateTriggerRequest>.Some(value), default, default);

    public static V2TriggersRequest1 PayAsYouGoUpdateTriggerRequest(PayAsYouGoUpdateTriggerRequest value) =>
        new(default, default, default, default, Optional<PayAsYouGoUpdateTriggerRequest>.Some(value), default);

    public static V2TriggersRequest1 Updatetriggerchunk(Updatetriggerchunk value) =>
        new(default, default, default, default, default, Optional<Updatetriggerchunk>.Some(value));

    public bool TryGetAccountLevelUpdateTriggerRequest(out AccountLevelUpdateTriggerRequest value) =>
        _accountLevelUpdateTriggerRequestValue.TryGetValue(out value);

    public bool TryGetDeviceLevelUpdateTriggerRequest(out DeviceLevelUpdateTriggerRequest value) =>
        _deviceLevelUpdateTriggerRequestValue.TryGetValue(out value);

    public bool TryGetAccountGroupShareUpdateTriggerRequest(out AccountGroupShareUpdateTriggerRequest value) =>
        _accountGroupShareUpdateTriggerRequestValue.TryGetValue(out value);

    public bool TryGetAccountShareUpdateTriggerRequest(out AccountShareUpdateTriggerRequest value) =>
        _accountShareUpdateTriggerRequestValue.TryGetValue(out value);

    public bool TryGetPayAsYouGoUpdateTriggerRequest(out PayAsYouGoUpdateTriggerRequest value) =>
        _payAsYouGoUpdateTriggerRequestValue.TryGetValue(out value);

    public bool TryGetUpdatetriggerchunk(out Updatetriggerchunk value) =>
        _updatetriggerchunkValue.TryGetValue(out value);

    public static implicit operator V2TriggersRequest1(AccountLevelUpdateTriggerRequest value) =>
        AccountLevelUpdateTriggerRequest(value);

    public static implicit operator V2TriggersRequest1(DeviceLevelUpdateTriggerRequest value) =>
        DeviceLevelUpdateTriggerRequest(value);

    public static implicit operator V2TriggersRequest1(AccountGroupShareUpdateTriggerRequest value) =>
        AccountGroupShareUpdateTriggerRequest(value);

    public static implicit operator V2TriggersRequest1(AccountShareUpdateTriggerRequest value) =>
        AccountShareUpdateTriggerRequest(value);

    public static implicit operator V2TriggersRequest1(PayAsYouGoUpdateTriggerRequest value) =>
        PayAsYouGoUpdateTriggerRequest(value);

    public static implicit operator V2TriggersRequest1(Updatetriggerchunk value) => Updatetriggerchunk(value);
}

file sealed class V2TriggersRequest1Converter : JsonConverter<V2TriggersRequest1>
{
    public override V2TriggersRequest1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<AccountLevelUpdateTriggerRequest>(root,
            options,
            out var accountLevelUpdateTriggerRequestValue))
        {
            return V2TriggersRequest1.AccountLevelUpdateTriggerRequest(accountLevelUpdateTriggerRequestValue);
        }
        if (JsonSerializer.TryDeserialize<DeviceLevelUpdateTriggerRequest>(root,
            options,
            out var deviceLevelUpdateTriggerRequestValue))
        {
            return V2TriggersRequest1.DeviceLevelUpdateTriggerRequest(deviceLevelUpdateTriggerRequestValue);
        }
        if (JsonSerializer.TryDeserialize<AccountGroupShareUpdateTriggerRequest>(root,
            options,
            out var accountGroupShareUpdateTriggerRequestValue))
        {
            return V2TriggersRequest1.AccountGroupShareUpdateTriggerRequest(accountGroupShareUpdateTriggerRequestValue);
        }
        if (JsonSerializer.TryDeserialize<AccountShareUpdateTriggerRequest>(root,
            options,
            out var accountShareUpdateTriggerRequestValue))
        {
            return V2TriggersRequest1.AccountShareUpdateTriggerRequest(accountShareUpdateTriggerRequestValue);
        }
        if (JsonSerializer.TryDeserialize<PayAsYouGoUpdateTriggerRequest>(root,
            options,
            out var payAsYouGoUpdateTriggerRequestValue))
        {
            return V2TriggersRequest1.PayAsYouGoUpdateTriggerRequest(payAsYouGoUpdateTriggerRequestValue);
        }
        if (JsonSerializer.TryDeserialize<Updatetriggerchunk>(root, options, out var updatetriggerchunkValue))
        {
            return V2TriggersRequest1.Updatetriggerchunk(updatetriggerchunkValue);
        }
        throw new JsonException($"JSON does not match AccountLevelUpdateTriggerRequest or DeviceLevelUpdateTriggerRequest or AccountGroupShareUpdateTriggerRequest or AccountShareUpdateTriggerRequest or PayAsYouGoUpdateTriggerRequest or Updatetriggerchunk schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, V2TriggersRequest1 value, JsonSerializerOptions options)
    {
        if (value.TryGetAccountLevelUpdateTriggerRequest(out var accountLevelUpdateTriggerRequestValue))
        {
            JsonSerializer.Serialize(writer, accountLevelUpdateTriggerRequestValue, options);
        }
        else if (value.TryGetDeviceLevelUpdateTriggerRequest(out var deviceLevelUpdateTriggerRequestValue))
        {
            JsonSerializer.Serialize(writer, deviceLevelUpdateTriggerRequestValue, options);
        }
        else if (value.TryGetAccountGroupShareUpdateTriggerRequest(out var accountGroupShareUpdateTriggerRequestValue))
        {
            JsonSerializer.Serialize(writer, accountGroupShareUpdateTriggerRequestValue, options);
        }
        else if (value.TryGetAccountShareUpdateTriggerRequest(out var accountShareUpdateTriggerRequestValue))
        {
            JsonSerializer.Serialize(writer, accountShareUpdateTriggerRequestValue, options);
        }
        else if (value.TryGetPayAsYouGoUpdateTriggerRequest(out var payAsYouGoUpdateTriggerRequestValue))
        {
            JsonSerializer.Serialize(writer, payAsYouGoUpdateTriggerRequestValue, options);
        }
        else if (value.TryGetUpdatetriggerchunk(out var updatetriggerchunkValue))
        {
            JsonSerializer.Serialize(writer, updatetriggerchunkValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(V2TriggersRequest1)} contains no valid value to serialize.");
        }
    }
}
