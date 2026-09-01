using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Verizon.Core.Extensions;
using Verizon.Core.Models;

namespace Verizon.Models.AnyOf;

[JsonConverter(typeof(TriggerAttributesOptionsConverter))]
public record TriggerAttributesOptions
{
    private readonly Optional<NotificationGroupNameTriggerAttribute> _notificationGroupNameTriggerAttributeValue;

    private readonly Optional<ServicePlanTriggerAttribute> _servicePlanTriggerAttributeValue;

    private readonly Optional<DataPercentage50TriggerAttribute> _dataPercentage50TriggerAttributeValue;

    private readonly Optional<DataPercentage75TriggerAttribute> _dataPercentage75TriggerAttributeValue;

    private readonly Optional<DataPercentage90TriggerAttribute> _dataPercentage90TriggerAttributeValue;

    private readonly Optional<DataPercentage100TriggerAttribute> _dataPercentage100TriggerAttributeValue;

    private TriggerAttributesOptions(Optional<NotificationGroupNameTriggerAttribute> notificationGroupNameTriggerAttributeValue,
        Optional<ServicePlanTriggerAttribute> servicePlanTriggerAttributeValue,
        Optional<DataPercentage50TriggerAttribute> dataPercentage50TriggerAttributeValue,
        Optional<DataPercentage75TriggerAttribute> dataPercentage75TriggerAttributeValue,
        Optional<DataPercentage90TriggerAttribute> dataPercentage90TriggerAttributeValue,
        Optional<DataPercentage100TriggerAttribute> dataPercentage100TriggerAttributeValue)
    {
        _notificationGroupNameTriggerAttributeValue = notificationGroupNameTriggerAttributeValue;
        _servicePlanTriggerAttributeValue = servicePlanTriggerAttributeValue;
        _dataPercentage50TriggerAttributeValue = dataPercentage50TriggerAttributeValue;
        _dataPercentage75TriggerAttributeValue = dataPercentage75TriggerAttributeValue;
        _dataPercentage90TriggerAttributeValue = dataPercentage90TriggerAttributeValue;
        _dataPercentage100TriggerAttributeValue = dataPercentage100TriggerAttributeValue;
    }

    public static TriggerAttributesOptions NotificationGroupNameTriggerAttribute(NotificationGroupNameTriggerAttribute value) =>
        new(Optional<NotificationGroupNameTriggerAttribute>.Some(value), default, default, default, default, default);

    public static TriggerAttributesOptions ServicePlanTriggerAttribute(ServicePlanTriggerAttribute value) =>
        new(default, Optional<ServicePlanTriggerAttribute>.Some(value), default, default, default, default);

    public static TriggerAttributesOptions DataPercentage50TriggerAttribute(DataPercentage50TriggerAttribute value) =>
        new(default, default, Optional<DataPercentage50TriggerAttribute>.Some(value), default, default, default);

    public static TriggerAttributesOptions DataPercentage75TriggerAttribute(DataPercentage75TriggerAttribute value) =>
        new(default, default, default, Optional<DataPercentage75TriggerAttribute>.Some(value), default, default);

    public static TriggerAttributesOptions DataPercentage90TriggerAttribute(DataPercentage90TriggerAttribute value) =>
        new(default, default, default, default, Optional<DataPercentage90TriggerAttribute>.Some(value), default);

    public static TriggerAttributesOptions DataPercentage100TriggerAttribute(DataPercentage100TriggerAttribute value) =>
        new(default, default, default, default, default, Optional<DataPercentage100TriggerAttribute>.Some(value));

    public bool TryGetNotificationGroupNameTriggerAttribute(out NotificationGroupNameTriggerAttribute value) =>
        _notificationGroupNameTriggerAttributeValue.TryGetValue(out value);

    public bool TryGetServicePlanTriggerAttribute(out ServicePlanTriggerAttribute value) =>
        _servicePlanTriggerAttributeValue.TryGetValue(out value);

    public bool TryGetDataPercentage50TriggerAttribute(out DataPercentage50TriggerAttribute value) =>
        _dataPercentage50TriggerAttributeValue.TryGetValue(out value);

    public bool TryGetDataPercentage75TriggerAttribute(out DataPercentage75TriggerAttribute value) =>
        _dataPercentage75TriggerAttributeValue.TryGetValue(out value);

    public bool TryGetDataPercentage90TriggerAttribute(out DataPercentage90TriggerAttribute value) =>
        _dataPercentage90TriggerAttributeValue.TryGetValue(out value);

    public bool TryGetDataPercentage100TriggerAttribute(out DataPercentage100TriggerAttribute value) =>
        _dataPercentage100TriggerAttributeValue.TryGetValue(out value);

    public static implicit operator TriggerAttributesOptions(NotificationGroupNameTriggerAttribute value) =>
        NotificationGroupNameTriggerAttribute(value);

    public static implicit operator TriggerAttributesOptions(ServicePlanTriggerAttribute value) =>
        ServicePlanTriggerAttribute(value);

    public static implicit operator TriggerAttributesOptions(DataPercentage50TriggerAttribute value) =>
        DataPercentage50TriggerAttribute(value);

    public static implicit operator TriggerAttributesOptions(DataPercentage75TriggerAttribute value) =>
        DataPercentage75TriggerAttribute(value);

    public static implicit operator TriggerAttributesOptions(DataPercentage90TriggerAttribute value) =>
        DataPercentage90TriggerAttribute(value);

    public static implicit operator TriggerAttributesOptions(DataPercentage100TriggerAttribute value) =>
        DataPercentage100TriggerAttribute(value);
}

file sealed class TriggerAttributesOptionsConverter : JsonConverter<TriggerAttributesOptions>
{
    public override TriggerAttributesOptions Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<NotificationGroupNameTriggerAttribute>(root,
            options,
            out var notificationGroupNameTriggerAttributeValue))
        {
            return TriggerAttributesOptions.NotificationGroupNameTriggerAttribute(notificationGroupNameTriggerAttributeValue);
        }
        if (JsonSerializer.TryDeserialize<ServicePlanTriggerAttribute>(root,
            options,
            out var servicePlanTriggerAttributeValue))
        {
            return TriggerAttributesOptions.ServicePlanTriggerAttribute(servicePlanTriggerAttributeValue);
        }
        if (JsonSerializer.TryDeserialize<DataPercentage50TriggerAttribute>(root,
            options,
            out var dataPercentage50TriggerAttributeValue))
        {
            return TriggerAttributesOptions.DataPercentage50TriggerAttribute(dataPercentage50TriggerAttributeValue);
        }
        if (JsonSerializer.TryDeserialize<DataPercentage75TriggerAttribute>(root,
            options,
            out var dataPercentage75TriggerAttributeValue))
        {
            return TriggerAttributesOptions.DataPercentage75TriggerAttribute(dataPercentage75TriggerAttributeValue);
        }
        if (JsonSerializer.TryDeserialize<DataPercentage90TriggerAttribute>(root,
            options,
            out var dataPercentage90TriggerAttributeValue))
        {
            return TriggerAttributesOptions.DataPercentage90TriggerAttribute(dataPercentage90TriggerAttributeValue);
        }
        if (JsonSerializer.TryDeserialize<DataPercentage100TriggerAttribute>(root,
            options,
            out var dataPercentage100TriggerAttributeValue))
        {
            return TriggerAttributesOptions.DataPercentage100TriggerAttribute(dataPercentage100TriggerAttributeValue);
        }
        throw new JsonException($"JSON does not match NotificationGroupNameTriggerAttribute or ServicePlanTriggerAttribute or DataPercentage50TriggerAttribute or DataPercentage75TriggerAttribute or DataPercentage90TriggerAttribute or DataPercentage100TriggerAttribute schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TriggerAttributesOptions value, JsonSerializerOptions options)
    {
        if (value.TryGetNotificationGroupNameTriggerAttribute(out var notificationGroupNameTriggerAttributeValue))
        {
            JsonSerializer.Serialize(writer, notificationGroupNameTriggerAttributeValue, options);
        }
        else if (value.TryGetServicePlanTriggerAttribute(out var servicePlanTriggerAttributeValue))
        {
            JsonSerializer.Serialize(writer, servicePlanTriggerAttributeValue, options);
        }
        else if (value.TryGetDataPercentage50TriggerAttribute(out var dataPercentage50TriggerAttributeValue))
        {
            JsonSerializer.Serialize(writer, dataPercentage50TriggerAttributeValue, options);
        }
        else if (value.TryGetDataPercentage75TriggerAttribute(out var dataPercentage75TriggerAttributeValue))
        {
            JsonSerializer.Serialize(writer, dataPercentage75TriggerAttributeValue, options);
        }
        else if (value.TryGetDataPercentage90TriggerAttribute(out var dataPercentage90TriggerAttributeValue))
        {
            JsonSerializer.Serialize(writer, dataPercentage90TriggerAttributeValue, options);
        }
        else if (value.TryGetDataPercentage100TriggerAttribute(out var dataPercentage100TriggerAttributeValue))
        {
            JsonSerializer.Serialize(writer, dataPercentage100TriggerAttributeValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(TriggerAttributesOptions)} contains no valid value to serialize.");
        }
    }
}
