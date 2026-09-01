# Reference

> Source: [VerizonClient](VerizonClient.cs)

## GbiDeviceActions5

> Source: [GbiDeviceActions5](Api/GbiDeviceActions5.cs)

<details>
<summary><code>Task&lt;GbiRequestResponse5&gt; BusinessInternetServiceplanchange(GbichangeRequest5 body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Change a device's service plan to use 5G BI.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GbiDeviceActions5.BusinessInternetServiceplanchange(body);
    // TODO: Handle 'response' of type GbiRequestResponse5
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GbichangeRequest5](Models/GbichangeRequest5.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GbiRequestResponse5](Models/GbiRequestResponse5.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GbiRequestResponse5&gt; BusinessInternetactivateUsingPost(GbiactivateRequest5 body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uses the device's ICCID and IMEI to activate service.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GbiDeviceActions5.BusinessInternetactivateUsingPost(body);
    // TODO: Handle 'response' of type GbiRequestResponse5
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GbiactivateRequest5](Models/GbiactivateRequest5.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GbiRequestResponse5](Models/GbiRequestResponse5.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GbideviceDetailsresponse5&gt; BusinessInternetlistDeviceInformation(GbideviceId5 body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uses the decive's Integrated Circuit Card Identification Number (ICCID) to retrive and display the device's properties.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GbiDeviceActions5.BusinessInternetlistDeviceInformation(body);
    // TODO: Handle 'response' of type GbideviceDetailsresponse5
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GbideviceId5](Models/GbideviceId5.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GbideviceDetailsresponse5](Models/GbideviceDetailsresponse5.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountDevices

> Source: [AccountDevices](Api/AccountDevices.cs)

<details>
<summary><code>Task&lt;V3AccountDeviceList&gt; GetAccountDeviceInformation(string acc, string? lastSeenDeviceId, DevicesProtocol? protocol, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve account device information such as reported firmware on the devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountDevices.GetAccountDeviceInformation(acc, lastSeenDeviceId, protocol);
    // TODO: Handle 'response' of type V3AccountDeviceList
}
catch (SdkException<GetAccountDeviceInformationError> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>acc</code> | <code>string</code> | Account identifier. |
| <code>lastSeenDeviceId</code> | <code>string?</code> | Last seen device identifier. |
| <code>protocol</code> | <code>[DevicesProtocol?](Models/Enums/DevicesProtocol.cs)</code> | Filter to retrieve a specific protocol type used. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V3AccountDeviceList](Models/V3AccountDeviceList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAccountDeviceInformationError](Errors/GetAccountDeviceInformationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceListResult&gt; ListAccountDevicesInformation(string acc, DeviceImei body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve device information for a list of devices on an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountDevices.ListAccountDevicesInformation(acc, body);
    // TODO: Handle 'response' of type DeviceListResult
}
catch (SdkException<ListAccountDevicesInformationError> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>acc</code> | <code>string</code> | Account identifier. |
| <code>body</code> | <code>[DeviceImei](Models/DeviceImei.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceListResult](Models/DeviceListResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListAccountDevicesInformationError](Errors/ListAccountDevicesInformationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountRequests

> Source: [AccountRequests](Api/AccountRequests.cs)

<details>
<summary><code>Task&lt;AsynchronousRequestResult&gt; GetCurrentAsynchronousRequestStatus(string aname, string requestId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the current status of an asynchronous request that was made for a single device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountRequests.GetCurrentAsynchronousRequestStatus(aname, requestId);
    // TODO: Handle 'response' of type AsynchronousRequestResult
}
catch (SdkException<GetCurrentAsynchronousRequestStatusError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>aname</code> | <code>string</code> | Account name. |
| <code>requestId</code> | <code>string</code> | UUID from synchronous response. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AsynchronousRequestResult](Models/AsynchronousRequestResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCurrentAsynchronousRequestStatusError](Errors/GetCurrentAsynchronousRequestStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountServiceController

> Source: [AccountServiceController](Api/AccountServiceController.cs)

<details>
<summary><code>Task&lt;GetAccountInformationResponseforplanner&gt; GetAccountInformationUsingGet(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns aaccount information associated with a specified account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountServiceController.GetAccountInformationUsingGet(accountName);
    // TODO: Handle 'response' of type GetAccountInformationResponseforplanner
}
catch (SdkException<GetAccountInformationUsingGetError> ex)
{
    if (ex.Error.TryGetRestErrorResponseforplanner(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponseforplanner
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | The account's numeric name, including leading zeroes. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetAccountInformationResponseforplanner](Models/GetAccountInformationResponseforplanner.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAccountInformationUsingGetError](Errors/GetAccountInformationUsingGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountSubscriptions

> Source: [AccountSubscriptions](Api/AccountSubscriptions.cs)

<details>
<summary><code>Task&lt;SecuritySubscriptionResult&gt; ListAccountSubscriptions(string? xRequestId, SecuritySubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the total number of SIM-Secure for IoT subscription licenses purchased for your account by license type, and lists the number of licenses assigned and available for each license type.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountSubscriptions.ListAccountSubscriptions(xRequestId, body);
    // TODO: Handle 'response' of type SecuritySubscriptionResult
}
catch (SdkException<ListAccountSubscriptionsError> ex)
{
    if (ex.Error.TryGetSecurityResult(out var error))
    {
        // TODO: Handle 'error' of type SecurityResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>xRequestId</code> | <code>string?</code> | Transaction Id. |
| <code>body</code> | <code>[SecuritySubscriptionRequest](Models/SecuritySubscriptionRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SecuritySubscriptionResult](Models/SecuritySubscriptionResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListAccountSubscriptionsError](Errors/ListAccountSubscriptionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Accounts

> Source: [Accounts](Api/Accounts.cs)

<details>
<summary><code>Task&lt;Account&gt; GetAccountInformation(string aname, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns information about a specified account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Accounts.GetAccountInformation(aname);
    // TODO: Handle 'response' of type Account
}
catch (SdkException<GetAccountInformationError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>aname</code> | <code>string</code> | Account name. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Account](Models/Account.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAccountInformationError](Errors/GetAccountInformationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountLeadsResult&gt; ListAccountLeads(string aname, long? next, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

When HTTP status is 202, a URL will be returned in the Location header of the form /leads/{aname}?next={token}. This URL can be used to request the next set of leads.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Accounts.ListAccountLeads(aname, next);
    // TODO: Handle 'response' of type AccountLeadsResult
}
catch (SdkException<ListAccountLeadsError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>aname</code> | <code>string</code> | Account name. |
| <code>next</code> | <code>long?</code> | Continue the previous query from the pageUrl in Location Header. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountLeadsResult](Models/AccountLeadsResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListAccountLeadsError](Errors/ListAccountLeadsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountStatesAndServices&gt; ListAccountStatesAndServices(string aname, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list and details of all custom services and states defined for a specified account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Accounts.ListAccountStatesAndServices(aname);
    // TODO: Handle 'response' of type AccountStatesAndServices
}
catch (SdkException<ListAccountStatesAndServicesError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>aname</code> | <code>string</code> | Account name. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountStatesAndServices](Models/AccountStatesAndServices.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListAccountStatesAndServicesError](Errors/ListAccountStatesAndServicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AnomalySettings

> Source: [AnomalySettings](Api/AnomalySettings.cs)

<details>
<summary><code>Task&lt;IntelligenceSuccessResult&gt; ActivateAnomalyDetection(AnomalyDetectionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uses the subscribed account ID to activate anomaly detection and set threshold values.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AnomalySettings.ActivateAnomalyDetection(body);
    // TODO: Handle 'response' of type IntelligenceSuccessResult
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AnomalyDetectionRequest](Models/AnomalyDetectionRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IntelligenceSuccessResult](Models/IntelligenceSuccessResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AnomalyDetectionSettings&gt; ListAnomalyDetectionSettings(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the current anomaly detection settings for an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AnomalySettings.ListAnomalyDetectionSettings(accountName);
    // TODO: Handle 'response' of type AnomalyDetectionSettings
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | The name of the subscribed account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AnomalyDetectionSettings](Models/AnomalyDetectionSettings.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IntelligenceSuccessResult&gt; ResetAnomalyDetectionParameters(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Resets the thresholds to zero.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AnomalySettings.ResetAnomalyDetectionParameters(accountName);
    // TODO: Handle 'response' of type IntelligenceSuccessResult
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | The name of the subscribed account. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IntelligenceSuccessResult](Models/IntelligenceSuccessResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AnomalyTriggers

> Source: [AnomalyTriggers](Api/AnomalyTriggers.cs)

<details>
<summary><code>Task&lt;AnomalyDetectionTrigger&gt; CreateAnomalyDetectionTrigger(CreateTriggerRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This corresponds to the M2M-MC SOAP interface, ```CreateTrigger```.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AnomalyTriggers.CreateAnomalyDetectionTrigger(body);
    // TODO: Handle 'response' of type AnomalyDetectionTrigger
}
catch (SdkException<CreateAnomalyDetectionTriggerError> ex)
{
    if (ex.Error.TryGetIntelligenceResult(out var error))
    {
        // TODO: Handle 'error' of type IntelligenceResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateTriggerRequest](Models/CreateTriggerRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AnomalyDetectionTrigger](Models/AnomalyDetectionTrigger.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateAnomalyDetectionTriggerError](Errors/CreateAnomalyDetectionTriggerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AnomalyDetectionTrigger&gt; DeleteAnomalyDetectionTrigger(string triggerId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a specific trigger ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AnomalyTriggers.DeleteAnomalyDetectionTrigger(triggerId);
    // TODO: Handle 'response' of type AnomalyDetectionTrigger
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>triggerId</code> | <code>string</code> | The trigger ID to be deleted |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AnomalyDetectionTrigger](Models/AnomalyDetectionTrigger.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;GetTriggerResponseList&gt;&gt; ListAnomalyDetectionTriggerSettings(string triggerId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This corresponds to the M2M-MC SOAP interface, ```GetTriggers```.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AnomalyTriggers.ListAnomalyDetectionTriggerSettings(triggerId);
    // TODO: Handle 'response' of type IReadOnlyList<GetTriggerResponseList>
}
catch (SdkException<ListAnomalyDetectionTriggerSettingsError> ex)
{
    if (ex.Error.TryGetIntelligenceResult(out var error))
    {
        // TODO: Handle 'error' of type IntelligenceResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>triggerId</code> | <code>string</code> | trigger ID |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[GetTriggerResponseList](Models/GetTriggerResponseList.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListAnomalyDetectionTriggerSettingsError](Errors/ListAnomalyDetectionTriggerSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;GetTriggerResponseList&gt;&gt; ListAnomalyDetectionTriggers(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This corresponds to the M2M-MC SOAP interface, ```GetTriggers```.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AnomalyTriggers.ListAnomalyDetectionTriggers();
    // TODO: Handle 'response' of type IReadOnlyList<GetTriggerResponseList>
}
catch (SdkException<ListAnomalyDetectionTriggersError> ex)
{
    if (ex.Error.TryGetIntelligenceResult(out var error))
    {
        // TODO: Handle 'error' of type IntelligenceResult
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[GetTriggerResponseList](Models/GetTriggerResponseList.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListAnomalyDetectionTriggersError](Errors/ListAnomalyDetectionTriggersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AnomalyDetectionTrigger&gt; UpdateAnomalyDetectionTrigger(UpdateTriggerRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This corresponds to the M2M-MC SOAP interface, ```UpdateTriggerRequest```.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AnomalyTriggers.UpdateAnomalyDetectionTrigger(body);
    // TODO: Handle 'response' of type AnomalyDetectionTrigger
}
catch (SdkException<UpdateAnomalyDetectionTriggerError> ex)
{
    if (ex.Error.TryGetIntelligenceResult(out var error))
    {
        // TODO: Handle 'error' of type IntelligenceResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[UpdateTriggerRequest](Models/UpdateTriggerRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AnomalyDetectionTrigger](Models/AnomalyDetectionTrigger.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateAnomalyDetectionTriggerError](Errors/UpdateAnomalyDetectionTriggerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AnomalyTriggersV2

> Source: [AnomalyTriggersV2](Api/AnomalyTriggersV2.cs)

<details>
<summary><code>Task&lt;AnomalyDetectionTrigger&gt; CreateAnomalyDetectionTriggerV2(IReadOnlyList&lt;CreateTriggerRequestOptions&gt; body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates the trigger to identify an anomaly.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AnomalyTriggersV2.CreateAnomalyDetectionTriggerV2(body);
    // TODO: Handle 'response' of type AnomalyDetectionTrigger
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>IReadOnlyList&lt;[CreateTriggerRequestOptions](Models/AnyOf/CreateTriggerRequestOptions.cs)&gt;</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AnomalyDetectionTrigger](Models/AnomalyDetectionTrigger.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AnomalyTriggerResult&gt; ListAnomalyDetectionTriggerSettingsV2(string triggerId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the values for a specific trigger ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AnomalyTriggersV2.ListAnomalyDetectionTriggerSettingsV2(triggerId);
    // TODO: Handle 'response' of type AnomalyTriggerResult
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>triggerId</code> | <code>string</code> | The trigger ID of a specific trigger. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AnomalyTriggerResult](Models/AnomalyTriggerResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IntelligenceSuccessResult&gt; UpdateAnomalyDetectionTriggerV2(IReadOnlyList&lt;UpdateTriggerRequestOptions&gt; body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an existing trigger using the account name.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AnomalyTriggersV2.UpdateAnomalyDetectionTriggerV2(body);
    // TODO: Handle 'response' of type IntelligenceSuccessResult
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>IReadOnlyList&lt;[UpdateTriggerRequestOptions](Models/AnyOf/UpdateTriggerRequestOptions.cs)&gt;</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IntelligenceSuccessResult](Models/IntelligenceSuccessResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Billing

> Source: [Billing](Api/Billing.cs)

<details>
<summary><code>Task&lt;ManagedAccountsAddResponse&gt; AddAccount(ManagedAccountsAddRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to add managed accounts to a primary account.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Billing.AddAccount(body);
    // TODO: Handle 'response' of type ManagedAccountsAddResponse
}
catch (SdkException<AddAccountError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ManagedAccountsAddRequest](Models/ManagedAccountsAddRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ManagedAccountsAddResponse](Models/ManagedAccountsAddResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddAccountError](Errors/AddAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ManagedAccountCancelResponse&gt; CancelManagedAccountAction(ManagedAccountCancelRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deactivates a managed billing service relationship between a managed account and the primary account. 

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Billing.CancelManagedAccountAction(body);
    // TODO: Handle 'response' of type ManagedAccountCancelResponse
}
catch (SdkException<CancelManagedAccountActionError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ManagedAccountCancelRequest](Models/ManagedAccountCancelRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ManagedAccountCancelResponse](Models/ManagedAccountCancelResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CancelManagedAccountActionError](Errors/CancelManagedAccountActionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ManagedAccountsGetAllResponse&gt; ListManagedAccount(string accountName, string serviceName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to retrieve the list of all accounts managed by a primary account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Billing.ListManagedAccount(accountName, serviceName);
    // TODO: Handle 'response' of type ManagedAccountsGetAllResponse
}
catch (SdkException<ListManagedAccountError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | Primary account identifier |
| <code>serviceName</code> | <code>string</code> | Service name |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ManagedAccountsGetAllResponse](Models/ManagedAccountsGetAllResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListManagedAccountError](Errors/ListManagedAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ManagedAccountsProvisionResponse&gt; ManagedAccountAction(ManagedAccountsProvisionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Activates a managed billing service relationship between a managed account and the primary account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Billing.ManagedAccountAction(body);
    // TODO: Handle 'response' of type ManagedAccountsProvisionResponse
}
catch (SdkException<ManagedAccountActionError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ManagedAccountsProvisionRequest](Models/ManagedAccountsProvisionRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ManagedAccountsProvisionResponse](Models/ManagedAccountsProvisionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ManagedAccountActionError](Errors/ManagedAccountActionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CampaignsV2

> Source: [CampaignsV2](Api/CampaignsV2.cs)

<details>
<summary><code>Task&lt;FotaV2SuccessResult&gt; CancelCampaign(string account, string campaignId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to cancel software upgrade. A software upgrade already started can not be cancelled.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV2.CancelCampaign(account, campaignId);
    // TODO: Handle 'response' of type FotaV2SuccessResult
}
catch (SdkException<CancelCampaignError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |
| <code>campaignId</code> | <code>string</code> | Unique identifier of campaign. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV2SuccessResult](Models/FotaV2SuccessResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CancelCampaignError](Errors/CancelCampaignError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CampaignSoftware&gt; GetCampaignInformation(string account, string campaignId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to get information of a software upgrade.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV2.GetCampaignInformation(account, campaignId);
    // TODO: Handle 'response' of type CampaignSoftware
}
catch (SdkException<GetCampaignInformationError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |
| <code>campaignId</code> | <code>string</code> | Software upgrade identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CampaignSoftware](Models/CampaignSoftware.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCampaignInformationError](Errors/GetCampaignInformationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CampaignSoftware&gt; ScheduleCampaignFirmwareUpgrade(string account, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to schedule a software upgrade.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV2.ScheduleCampaignFirmwareUpgrade(account);
    // TODO: Handle 'response' of type CampaignSoftware
}
catch (SdkException<ScheduleCampaignFirmwareUpgradeError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CampaignSoftware](Models/CampaignSoftware.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ScheduleCampaignFirmwareUpgradeError](Errors/ScheduleCampaignFirmwareUpgradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadAndScheduleFileResponse&gt; ScheduleFileUpgrade(string acc, UploadAndScheduleFileRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

You can upload configuration files and schedule them in a campaign to devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV2.ScheduleFileUpgrade(acc, body);
    // TODO: Handle 'response' of type UploadAndScheduleFileResponse
}
catch (SdkException<ScheduleFileUpgradeError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>acc</code> | <code>string</code> | Account identifier. |
| <code>body</code> | <code>[UploadAndScheduleFileRequest](Models/UploadAndScheduleFileRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadAndScheduleFileResponse](Models/UploadAndScheduleFileResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ScheduleFileUpgradeError](Errors/ScheduleFileUpgradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadAndScheduleFileResponse&gt; ScheduleSwUpgradeHttpDevices(string acc, SchedulesSoftwareUpgradeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Campaign time windows for downloading and installing software are available as long as the device OEM supports this.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV2.ScheduleSwUpgradeHttpDevices(acc, body);
    // TODO: Handle 'response' of type UploadAndScheduleFileResponse
}
catch (SdkException<ScheduleSwUpgradeHttpDevicesError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>acc</code> | <code>string</code> | Account identifier. |
| <code>body</code> | <code>[SchedulesSoftwareUpgradeRequest](Models/SchedulesSoftwareUpgradeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadAndScheduleFileResponse](Models/UploadAndScheduleFileResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ScheduleSwUpgradeHttpDevicesError](Errors/ScheduleSwUpgradeHttpDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CampaignSoftware&gt; UpdateCampaignDates(string account, string campaignId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to change campaign dates and time windows. Fields which need to remain unchanged should be also provided.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV2.UpdateCampaignDates(account, campaignId);
    // TODO: Handle 'response' of type CampaignSoftware
}
catch (SdkException<UpdateCampaignDatesError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |
| <code>campaignId</code> | <code>string</code> | Software upgrade information. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CampaignSoftware](Models/CampaignSoftware.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateCampaignDatesError](Errors/UpdateCampaignDatesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V2AddOrRemoveDeviceResult&gt; UpdateCampaignFirmwareDevices(string account, string campaignId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to Add or Remove devices to an existing software upgrade.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV2.UpdateCampaignFirmwareDevices(account, campaignId);
    // TODO: Handle 'response' of type V2AddOrRemoveDeviceResult
}
catch (SdkException<UpdateCampaignFirmwareDevicesError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |
| <code>campaignId</code> | <code>string</code> | Software upgrade information. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V2AddOrRemoveDeviceResult](Models/V2AddOrRemoveDeviceResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateCampaignFirmwareDevicesError](Errors/UpdateCampaignFirmwareDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CampaignsV3

> Source: [CampaignsV3](Api/CampaignsV3.cs)

<details>
<summary><code>Task&lt;FotaV3SuccessResult&gt; CancelCampaign2(string accountName, string campaignId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to cancel a firmware campaign. A firmware campaign already started can not be cancelled.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV3.CancelCampaign2(accountName, campaignId);
    // TODO: Handle 'response' of type FotaV3SuccessResult
}
catch (SdkException<CancelCampaign2Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | Account identifier. |
| <code>campaignId</code> | <code>string</code> | Firmware upgrade information. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV3SuccessResult](Models/FotaV3SuccessResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CancelCampaign2Error](Errors/CancelCampaign2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Campaign&gt; GetCampaignInformation2(string accountName, string campaignId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows the user to retrieve campaign level information for a specified campaign.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV3.GetCampaignInformation2(accountName, campaignId);
    // TODO: Handle 'response' of type Campaign
}
catch (SdkException<GetCampaignInformation2Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | Account identifier. |
| <code>campaignId</code> | <code>string</code> | Firmware upgrade identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Campaign](Models/Campaign.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCampaignInformation2Error](Errors/GetCampaignInformation2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FirmwareCampaign&gt; ScheduleCampaignFirmwareUpgrade2(string accountName, CampaignFirmwareUpgrade body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows a user to schedule a firmware upgrade for a list of devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV3.ScheduleCampaignFirmwareUpgrade2(accountName, body);
    // TODO: Handle 'response' of type FirmwareCampaign
}
catch (SdkException<ScheduleCampaignFirmwareUpgrade2Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | Account identifier. |
| <code>body</code> | <code>[CampaignFirmwareUpgrade](Models/CampaignFirmwareUpgrade.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FirmwareCampaign](Models/FirmwareCampaign.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ScheduleCampaignFirmwareUpgrade2Error](Errors/ScheduleCampaignFirmwareUpgrade2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FirmwareCampaign&gt; UpdateCampaignDates2(string acc, string campaignId, V3ChangeCampaignDatesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to change campaign dates and time windows. Fields which need to remain unchanged should be also provided.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV3.UpdateCampaignDates2(acc, campaignId, body);
    // TODO: Handle 'response' of type FirmwareCampaign
}
catch (SdkException<UpdateCampaignDates2Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>acc</code> | <code>string</code> | Account identifier. |
| <code>campaignId</code> | <code>string</code> | Firmware upgrade information. |
| <code>body</code> | <code>[V3ChangeCampaignDatesRequest](Models/V3ChangeCampaignDatesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FirmwareCampaign](Models/FirmwareCampaign.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateCampaignDates2Error](Errors/UpdateCampaignDates2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V3AddOrRemoveDeviceResult&gt; UpdateCampaignFirmwareDevices2(string acc, string campaignId, V3AddOrRemoveDeviceRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to Add or Remove devices to an existing campaign.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CampaignsV3.UpdateCampaignFirmwareDevices2(acc, campaignId, body);
    // TODO: Handle 'response' of type V3AddOrRemoveDeviceResult
}
catch (SdkException<UpdateCampaignFirmwareDevices2Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>acc</code> | <code>string</code> | Account identifier. |
| <code>campaignId</code> | <code>string</code> | Unique identifier of a campaign. |
| <code>body</code> | <code>[V3AddOrRemoveDeviceRequest](Models/V3AddOrRemoveDeviceRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V3AddOrRemoveDeviceResult](Models/V3AddOrRemoveDeviceResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateCampaignFirmwareDevices2Error](Errors/UpdateCampaignFirmwareDevices2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ClientLogging

> Source: [ClientLogging](Api/ClientLogging.cs)

<details>
<summary><code>Task DisableDeviceLogging(string account, string deviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Disables logging for a specific device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ClientLogging.DisableDeviceLogging(account, deviceId);
}
catch (SdkException<DisableDeviceLoggingError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |
| <code>deviceId</code> | <code>string</code> | Device IMEI identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DisableDeviceLoggingError](Errors/DisableDeviceLoggingError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DisableLoggingForDevices(string account, string deviceIds, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Turn logging off for a list of devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ClientLogging.DisableLoggingForDevices(account, deviceIds);
}
catch (SdkException<DisableLoggingForDevicesError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |
| <code>deviceIds</code> | <code>string</code> | The list of device IDs. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DisableLoggingForDevicesError](Errors/DisableLoggingForDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceLoggingStatus&gt; EnableDeviceLogging(string account, string deviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enables logging for a specific device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClientLogging.EnableDeviceLogging(account, deviceId);
    // TODO: Handle 'response' of type DeviceLoggingStatus
}
catch (SdkException<EnableDeviceLoggingError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |
| <code>deviceId</code> | <code>string</code> | Device IMEI identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceLoggingStatus](Models/DeviceLoggingStatus.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EnableDeviceLoggingError](Errors/EnableDeviceLoggingError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeviceLoggingStatus&gt;&gt; EnableLoggingForDevices(string account, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Each customer may have a maximum of 20 devices enabled for logging.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClientLogging.EnableLoggingForDevices(account);
    // TODO: Handle 'response' of type IReadOnlyList<DeviceLoggingStatus>
}
catch (SdkException<EnableLoggingForDevicesError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeviceLoggingStatus](Models/DeviceLoggingStatus.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EnableLoggingForDevicesError](Errors/EnableLoggingForDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeviceLog&gt;&gt; ListDeviceLogs(string account, string deviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets logs for a specific device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClientLogging.ListDeviceLogs(account, deviceId);
    // TODO: Handle 'response' of type IReadOnlyList<DeviceLog>
}
catch (SdkException<ListDeviceLogsError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |
| <code>deviceId</code> | <code>string</code> | Device IMEI identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeviceLog](Models/DeviceLog.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListDeviceLogsError](Errors/ListDeviceLogsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeviceLoggingStatus&gt;&gt; ListDevicesWithLoggingEnabled(string account, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an array of all devices in the specified account for which logging is enabled.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClientLogging.ListDevicesWithLoggingEnabled(account);
    // TODO: Handle 'response' of type IReadOnlyList<DeviceLoggingStatus>
}
catch (SdkException<ListDevicesWithLoggingEnabledError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeviceLoggingStatus](Models/DeviceLoggingStatus.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListDevicesWithLoggingEnabledError](Errors/ListDevicesWithLoggingEnabledError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CloudConnectorDevices

> Source: [CloudConnectorDevices](Api/CloudConnectorDevices.cs)

<details>
<summary><code>Task DeleteDeviceFromAccount(RemoveDeviceRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove a device from a ThingSpace account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.CloudConnectorDevices.DeleteDeviceFromAccount(body);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[RemoveDeviceRequest](Models/RemoveDeviceRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FindDeviceByPropertyResponseList&gt; FindDeviceByPropertyValues(QuerySubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Find devices by property values. Returns an array of all matching device resources.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CloudConnectorDevices.FindDeviceByPropertyValues(body);
    // TODO: Handle 'response' of type FindDeviceByPropertyResponseList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[QuerySubscriptionRequest](Models/QuerySubscriptionRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FindDeviceByPropertyResponseList](Models/FindDeviceByPropertyResponseList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchDeviceEventHistoryResponseList&gt; SearchDeviceEventHistory(SearchDeviceEventHistoryRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Search device event history to find events that match criteria.Sensor readings, configuration changes, and other device data are all stored as events.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CloudConnectorDevices.SearchDeviceEventHistory(body);
    // TODO: Handle 'response' of type SearchDeviceEventHistoryResponseList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SearchDeviceEventHistoryRequest](Models/SearchDeviceEventHistoryRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchDeviceEventHistoryResponseList](Models/SearchDeviceEventHistoryResponseList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchDeviceByPropertyResponseList&gt; SearchDevicesResourcesByPropertyValues(QuerySubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Search for devices by property values. Returns an array of all matching device resources.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CloudConnectorDevices.SearchDevicesResourcesByPropertyValues(body);
    // TODO: Handle 'response' of type SearchDeviceByPropertyResponseList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[QuerySubscriptionRequest](Models/QuerySubscriptionRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchDeviceByPropertyResponseList](Models/SearchDeviceByPropertyResponseList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchSensorHistoryResponseList&gt; SearchSensorReadings(string fieldname, SearchSensorHistoryRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the readings of a specified sensor, with the most recent reading first. Sensor readings are stored as events; this request an array of events.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CloudConnectorDevices.SearchSensorReadings(fieldname, body);
    // TODO: Handle 'response' of type SearchSensorHistoryResponseList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>fieldname</code> | <code>string</code> | The name of the sensor. |
| <code>body</code> | <code>[SearchSensorHistoryRequest](Models/SearchSensorHistoryRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchSensorHistoryResponseList](Models/SearchSensorHistoryResponseList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChangeConfigurationResponse&gt; UpdateDevicesConfigurationValue(ChangeConfigurationRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Change configuration values on a device, such as setting how often a device records and reports sensor readings.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CloudConnectorDevices.UpdateDevicesConfigurationValue(body);
    // TODO: Handle 'response' of type ChangeConfigurationResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ChangeConfigurationRequest](Models/ChangeConfigurationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChangeConfigurationResponse](Models/ChangeConfigurationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CloudConnectorSubscriptions

> Source: [CloudConnectorSubscriptions](Api/CloudConnectorSubscriptions.cs)

<details>
<summary><code>Task&lt;Subscription&gt; CreateSubscription(CreateSubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a subscription to define a streaming channel that sends data from devices in the account to an endpoint defined in a target resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CloudConnectorSubscriptions.CreateSubscription(body);
    // TODO: Handle 'response' of type Subscription
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateSubscriptionRequest](Models/CreateSubscriptionRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Subscription](Models/Subscription.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteSubscription(DeleteSubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove a subscription from a ThingSpace account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.CloudConnectorSubscriptions.DeleteSubscription(body);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeleteSubscriptionRequest](Models/DeleteSubscriptionRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Subscription&gt;&gt; QuerySubscription(QuerySubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Search for subscriptions by property values. Returns an array of all matching subscription resources.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CloudConnectorSubscriptions.QuerySubscription(body);
    // TODO: Handle 'response' of type IReadOnlyList<Subscription>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[QuerySubscriptionRequest](Models/QuerySubscriptionRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Subscription](Models/Subscription.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ConfigurationFiles

> Source: [ConfigurationFiles](Api/ConfigurationFiles.cs)

<details>
<summary><code>Task&lt;RetrievesAvailableFilesResponseList&gt; GetListOfFiles(string acc, string distributionType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

You can retrieve a list of configuration or supplementary of files for an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConfigurationFiles.GetListOfFiles(acc, distributionType);
    // TODO: Handle 'response' of type RetrievesAvailableFilesResponseList
}
catch (SdkException<GetListOfFilesError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>acc</code> | <code>string</code> | Account identifier. |
| <code>distributionType</code> | <code>string</code> | Filter the distributionType to only retrieve files for a specific distribution type. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrievesAvailableFilesResponseList](Models/RetrievesAvailableFilesResponseList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetListOfFilesError](Errors/GetListOfFilesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadConfigurationFilesResponse&gt; UploadConfigFile(string acc, BinaryContent? fileupload, string? fileVersion, string? make, string? model, string? localTargetPath, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uploads a configuration/supplementary file for an account. ThingSpace generates a fileName after the upload and is returned in the response.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConfigurationFiles.UploadConfigFile(acc,
        fileupload,
        fileVersion,
        make,
        model,
        localTargetPath);
    // TODO: Handle 'response' of type UploadConfigurationFilesResponse
}
catch (SdkException<UploadConfigFileError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>acc</code> | <code>string</code> | Account identifier. |
| <code>fileupload</code> | <code>BinaryContent?</code> | - |
| <code>fileVersion</code> | <code>string?</code> | - |
| <code>make</code> | <code>string?</code> | - |
| <code>model</code> | <code>string?</code> | - |
| <code>localTargetPath</code> | <code>string?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadConfigurationFilesResponse](Models/UploadConfigurationFilesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UploadConfigFileError](Errors/UploadConfigFileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ConnectivityCallbacks

> Source: [ConnectivityCallbacks](Api/ConnectivityCallbacks.cs)

<details>
<summary><code>Task&lt;CallbackActionResult&gt; DeregisterCallback(string aname, string sname, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Stops ThingSpace from sending callback messages for the specified account and service.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConnectivityCallbacks.DeregisterCallback(aname, sname);
    // TODO: Handle 'response' of type CallbackActionResult
}
catch (SdkException<DeregisterCallbackError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>aname</code> | <code>string</code> | Account name. |
| <code>sname</code> | <code>string</code> | Service name. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CallbackActionResult](Models/CallbackActionResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeregisterCallbackError](Errors/DeregisterCallbackError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ConnectivityManagementCallback&gt;&gt; ListRegisteredCallbacks(string aname, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the name and endpoint URL of the callback listening services registered for a given account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConnectivityCallbacks.ListRegisteredCallbacks(aname);
    // TODO: Handle 'response' of type IReadOnlyList<ConnectivityManagementCallback>
}
catch (SdkException<ListRegisteredCallbacksError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>aname</code> | <code>string</code> | Account name. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ConnectivityManagementCallback](Models/ConnectivityManagementCallback.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListRegisteredCallbacksError](Errors/ListRegisteredCallbacksError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CallbackActionResult&gt; RegisterCallback(string aname, RegisterCallbackRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

You are responsible for creating and running a listening process on your server at that URL.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConnectivityCallbacks.RegisterCallback(aname, body);
    // TODO: Handle 'response' of type CallbackActionResult
}
catch (SdkException<RegisterCallbackError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>aname</code> | <code>string</code> | Account name. |
| <code>body</code> | <code>[RegisterCallbackRequest](Models/RegisterCallbackRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CallbackActionResult](Models/CallbackActionResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RegisterCallbackError](Errors/RegisterCallbackError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CreatePricePlanTriggers

> Source: [CreatePricePlanTriggers](Api/CreatePricePlanTriggers.cs)

<details>
<summary><code>Task&lt;TriggerResponse&gt; CreateTriggerRules(V2TriggersRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a usage trigger at the account level, device level or a price plan trigger for all devices on the account

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreatePricePlanTriggers.CreateTriggerRules(body);
    // TODO: Handle 'response' of type TriggerResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[V2TriggersRequest](Models/AnyOf/V2TriggersRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TriggerResponse](Models/TriggerResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceActions

> Source: [DeviceActions](Api/DeviceActions.cs)

<details>
<summary><code>Task&lt;AccountDetails&gt; AccountInformation(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve all of the service plans, features and carriers associated with the account specified.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceActions.AccountInformation(accountName);
    // TODO: Handle 'response' of type AccountDetails
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountDetails](Models/AccountDetails.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; AggregateUsage(AggregateUsage body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve the aggregate usage for a device or a number of devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceActions.AggregateUsage(body);
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AggregateUsage](Models/AggregateUsage.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](Models/GioRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DailyUsageResponse&gt; DailyUsage(DailyUsage body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve the daily usage for a device, for a specified period of time, segmented by day

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceActions.DailyUsage(body);
    // TODO: Handle 'response' of type DailyUsageResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DailyUsage](Models/DailyUsage.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DailyUsageResponse](Models/DailyUsageResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StatusResponse&gt; GetAsynchronousRequestStatus(string accountName, string requestId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get the status of an asynchronous request made with the Device Actions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceActions.GetAsynchronousRequestStatus(accountName, requestId);
    // TODO: Handle 'response' of type StatusResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | - |
| <code>requestId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StatusResponse](Models/StatusResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; RetrieveDeviceProvisioningHistory(ProvhistoryRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve the provisioning history of a specific device or devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceActions.RetrieveDeviceProvisioningHistory(body);
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ProvhistoryRequest](Models/ProvhistoryRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](Models/GioRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; RetrieveTheGlobalDeviceList(GetDeviceListWithProfilesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Allows the profile to fetch the complete device list. This works with Verizon US and Global profiles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceActions.RetrieveTheGlobalDeviceList(body);
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GetDeviceListWithProfilesRequest](Models/GetDeviceListWithProfilesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](Models/GioRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountDetails&gt; ServicePlanList(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve all of the service plans, features and carriers associated with the account specified.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceActions.ServicePlanList(accountName);
    // TODO: Handle 'response' of type AccountDetails
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountDetails](Models/AccountDetails.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceCredentialManagement

> Source: [DeviceCredentialManagement](Api/DeviceCredentialManagement.cs)

<details>
<summary><code>Task&lt;DropResponse&gt; DropCredentials(CredentialsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceCredentialManagement.DropCredentials(body);
    // TODO: Handle 'response' of type DropResponse
}
catch (SdkException<DropCredentialsError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CredentialsRequest](Models/CredentialsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DropResponse](Models/DropResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DropCredentialsError](Errors/DropCredentialsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenerateResponse&gt; GenerateCredentials(CredentialsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceCredentialManagement.GenerateCredentials(body);
    // TODO: Handle 'response' of type GenerateResponse
}
catch (SdkException<GenerateCredentialsError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CredentialsRequest](Models/CredentialsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateResponse](Models/GenerateResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GenerateCredentialsError](Errors/GenerateCredentialsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenerateResponse&gt; ResetCredentials(CredentialsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceCredentialManagement.ResetCredentials(body);
    // TODO: Handle 'response' of type GenerateResponse
}
catch (SdkException<ResetCredentialsError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CredentialsRequest](Models/CredentialsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateResponse](Models/GenerateResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ResetCredentialsError](Errors/ResetCredentialsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveResponse&gt; RetrieveCredentials(CredentialsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceCredentialManagement.RetrieveCredentials(body);
    // TODO: Handle 'response' of type RetrieveResponse
}
catch (SdkException<RetrieveCredentialsError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CredentialsRequest](Models/CredentialsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveResponse](Models/RetrieveResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RetrieveCredentialsError](Errors/RetrieveCredentialsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceDiagnostics

> Source: [DeviceDiagnostics](Api/DeviceDiagnostics.cs)

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; DeviceReachabilityStatusUsingPost(NotificationReportStatusRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

If the devices do not already exist in the account, this API resource adds them before activation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceDiagnostics.DeviceReachabilityStatusUsingPost(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<DeviceReachabilityStatusUsingPostError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[NotificationReportStatusRequest](Models/NotificationReportStatusRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeviceReachabilityStatusUsingPostError](Errors/DeviceReachabilityStatusUsingPostError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; RetrieveActiveMonitorsUsingPost(RetrieveMonitorsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve all the active monitors.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceDiagnostics.RetrieveActiveMonitorsUsingPost(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<RetrieveActiveMonitorsUsingPostError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[RetrieveMonitorsRequest](Models/RetrieveMonitorsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RetrieveActiveMonitorsUsingPostError](Errors/RetrieveActiveMonitorsUsingPostError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceGroups

> Source: [DeviceGroups](Api/DeviceGroups.cs)

<details>
<summary><code>Task&lt;ConnectivityManagementSuccessResult&gt; CreateDeviceGroup(CreateDeviceGroupRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a new device group and optionally add devices to the group. Device groups can make it easier to manage similar devices and to get reports on their usage.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceGroups.CreateDeviceGroup(body);
    // TODO: Handle 'response' of type ConnectivityManagementSuccessResult
}
catch (SdkException<CreateDeviceGroupError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateDeviceGroupRequest](Models/CreateDeviceGroupRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConnectivityManagementSuccessResult](Models/ConnectivityManagementSuccessResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateDeviceGroupError](Errors/CreateDeviceGroupError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConnectivityManagementSuccessResult&gt; DeleteDeviceGroup(string aname, string gname, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a device group from the account. Devices in the group are moved to the default device group and are not deleted from the account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceGroups.DeleteDeviceGroup(aname, gname);
    // TODO: Handle 'response' of type ConnectivityManagementSuccessResult
}
catch (SdkException<DeleteDeviceGroupError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>aname</code> | <code>string</code> | Account name. |
| <code>gname</code> | <code>string</code> | Group name. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConnectivityManagementSuccessResult](Models/ConnectivityManagementSuccessResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteDeviceGroupError](Errors/DeleteDeviceGroupError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceGroupDevicesData&gt; GetDeviceGroupInformation(string aname, string gname, long? next, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

When HTTP status is 202, a URL will be returned in the Location header of the form /groups/{aname}/name/{gname}/?next={token}. This URL can be used to request the next set of groups.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceGroups.GetDeviceGroupInformation(aname, gname, next);
    // TODO: Handle 'response' of type DeviceGroupDevicesData
}
catch (SdkException<GetDeviceGroupInformationError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>aname</code> | <code>string</code> | Account name. |
| <code>gname</code> | <code>string</code> | Group name. |
| <code>next</code> | <code>long?</code> | Continue the previous query from the pageUrl pagetoken. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceGroupDevicesData](Models/DeviceGroupDevicesData.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetDeviceGroupInformationError](Errors/GetDeviceGroupInformationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeviceGroup&gt;&gt; ListDeviceGroups(string aname, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all device groups in a specified account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceGroups.ListDeviceGroups(aname);
    // TODO: Handle 'response' of type IReadOnlyList<DeviceGroup>
}
catch (SdkException<ListDeviceGroupsError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>aname</code> | <code>string</code> | Account name. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeviceGroup](Models/DeviceGroup.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListDeviceGroupsError](Errors/ListDeviceGroupsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConnectivityManagementSuccessResult&gt; UpdateDeviceGroup(string aname, string gname, DeviceGroupUpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Make changes to a device group, including changing the name and description, and adding or removing devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceGroups.UpdateDeviceGroup(aname, gname, body);
    // TODO: Handle 'response' of type ConnectivityManagementSuccessResult
}
catch (SdkException<UpdateDeviceGroupError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>aname</code> | <code>string</code> | Account name. |
| <code>gname</code> | <code>string</code> | Group name. |
| <code>body</code> | <code>[DeviceGroupUpdateRequest](Models/DeviceGroupUpdateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConnectivityManagementSuccessResult](Models/ConnectivityManagementSuccessResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateDeviceGroupError](Errors/UpdateDeviceGroupError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceLocationCallbacks

> Source: [DeviceLocationCallbacks](Api/DeviceLocationCallbacks.cs)

<details>
<summary><code>Task&lt;TransactionId&gt; CancelAsyncReport(string txid, string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancel an asynchronous report request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceLocationCallbacks.CancelAsyncReport(txid, accountName);
    // TODO: Handle 'response' of type TransactionId
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>txid</code> | <code>string</code> | The `transactionId` value. |
| <code>accountName</code> | <code>string</code> | Account identifier in "##########-#####". |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionId](Models/TransactionId.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceLocationSuccessResult&gt; DeregisterCallback2(string accountName, CallbackServiceName service, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deregister a URL to stop receiving callback messages.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceLocationCallbacks.DeregisterCallback2(accountName, service);
    // TODO: Handle 'response' of type DeviceLocationSuccessResult
}
catch (SdkException<DeregisterCallback2Error> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | Account number. |
| <code>service</code> | <code>[CallbackServiceName](Models/Enums/CallbackServiceName.cs)</code> | Callback service name. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceLocationSuccessResult](Models/DeviceLocationSuccessResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeregisterCallback2Error](Errors/DeregisterCallback2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeviceLocationCallback&gt;&gt; ListRegisteredCallbacks2(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all registered callback URLs for the account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceLocationCallbacks.ListRegisteredCallbacks2(accountName);
    // TODO: Handle 'response' of type IReadOnlyList<DeviceLocationCallback>
}
catch (SdkException<ListRegisteredCallbacks2Error> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | Account number. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeviceLocationCallback](Models/DeviceLocationCallback.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListRegisteredCallbacks2Error](Errors/ListRegisteredCallbacks2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CallbackRegistrationResult&gt; RegisterCallback2(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provide a URL to receive messages from a ThingSpace callback service.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceLocationCallbacks.RegisterCallback2(accountName);
    // TODO: Handle 'response' of type CallbackRegistrationResult
}
catch (SdkException<RegisterCallback2Error> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | Account number. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CallbackRegistrationResult](Models/CallbackRegistrationResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RegisterCallback2Error](Errors/RegisterCallback2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceManagement

> Source: [DeviceManagement](Api/DeviceManagement.cs)

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; ActivateServiceForDevices(CarrierActivateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

If the devices do not already exist in the account, this API resource adds them before activation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.ActivateServiceForDevices(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<ActivateServiceForDevicesError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CarrierActivateRequest](Models/CarrierActivateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ActivateServiceForDevicesError](Errors/ActivateServiceForDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;AddDevicesResult&gt;&gt; AddDevices(AddDevicesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use this API if you want to manage some device settings before you are ready to activate service for the devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.AddDevices(body);
    // TODO: Handle 'response' of type IReadOnlyList<AddDevicesResult>
}
catch (SdkException<AddDevicesError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AddDevicesRequest](Models/AddDevicesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[AddDevicesResult](Models/AddDevicesResult.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddDevicesError](Errors/AddDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; BilledUsageInfo(BilledusageListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets billed usage for for either multiple devices or an entire billing account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.BilledUsageInfo(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<BilledUsageInfoError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[BilledusageListRequest](Models/BilledusageListRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[BilledUsageInfoError](Errors/BilledUsageInfoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; ChangeDevicesServicePlan(ServicePlanUpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the service plan for one or more devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.ChangeDevicesServicePlan(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<ChangeDevicesServicePlanError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ServicePlanUpdateRequest](Models/ServicePlanUpdateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ChangeDevicesServicePlanError](Errors/ChangeDevicesServicePlanError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; CheckDevicesAvailabilityForActivation(DeviceActivationRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Checks whether specified devices are registered by the manufacturer with the Verizon network and are available to be activated.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.CheckDevicesAvailabilityForActivation(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<CheckDevicesAvailabilityForActivationError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeviceActivationRequest](Models/DeviceActivationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CheckDevicesAvailabilityForActivationError](Errors/CheckDevicesAvailabilityForActivationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; DeactivateServiceForDevices(CarrierDeactivateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deactivating service for a device may result in an early termination fee (ETF) being charged to the account, depending on the terms of the contract with Verizon. If your contract allows ETF waivers and if you want to use one for a particular deactivation, set the etfWaiver value to True.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.DeactivateServiceForDevices(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<DeactivateServiceForDevicesError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CarrierDeactivateRequest](Models/CarrierDeactivateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeactivateServiceForDevicesError](Errors/DeactivateServiceForDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeleteDevicesResult&gt;&gt; DeleteDeactivatedDevices(DeleteDevicesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use this API to remove unneeded devices from an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.DeleteDeactivatedDevices(body);
    // TODO: Handle 'response' of type IReadOnlyList<DeleteDevicesResult>
}
catch (SdkException<DeleteDeactivatedDevicesError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeleteDevicesRequest](Models/DeleteDevicesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeleteDevicesResult](Models/DeleteDevicesResult.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteDeactivatedDevicesError](Errors/DeleteDeactivatedDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RequestResponse&gt; DeviceUpload(DeviceUploadRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Upload a device record

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.DeviceUpload(body);
    // TODO: Handle 'response' of type RequestResponse
}
catch (SdkException<DeviceUploadError> ex)
{
    if (ex.Error.TryGetRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponse
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeviceUploadRequest](Models/DeviceUploadRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestResponse](Models/RequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeviceUploadError](Errors/DeviceUploadError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; DeviceUploadStatus(CheckOrderStatusRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Checks the status of an activation order and lists where the order is in the provisioning process.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.DeviceUploadStatus(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<DeviceUploadStatusError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CheckOrderStatusRequest](Models/CheckOrderStatusRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeviceUploadStatusError](Errors/DeviceUploadStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceExtendedDiagnosticsResult&gt; GetDeviceExtendedDiagnosticInformation(DeviceExtendedDiagnosticsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns extended diagnostic information about a specified device, including connectivity, provisioning, billing and location status.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.GetDeviceExtendedDiagnosticInformation(body);
    // TODO: Handle 'response' of type DeviceExtendedDiagnosticsResult
}
catch (SdkException<GetDeviceExtendedDiagnosticInformationError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeviceExtendedDiagnosticsRequest](Models/DeviceExtendedDiagnosticsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceExtendedDiagnosticsResult](Models/DeviceExtendedDiagnosticsResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetDeviceExtendedDiagnosticInformationError](Errors/GetDeviceExtendedDiagnosticInformationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; GetDeviceServiceSuspensionStatus(DeviceSuspensionStatusRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns DeviceSuspensionStatus callback messages containing the current device state and information on how many days a device has been suspended and can continue to be suspended.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.GetDeviceServiceSuspensionStatus(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<GetDeviceServiceSuspensionStatusError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeviceSuspensionStatusRequest](Models/DeviceSuspensionStatusRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetDeviceServiceSuspensionStatusError](Errors/GetDeviceServiceSuspensionStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; ListCurrentDevicesPrlVersion(DevicePrlListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

4G and GSM devices do not have a PRL.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.ListCurrentDevicesPrlVersion(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<ListCurrentDevicesPrlVersionError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DevicePrlListRequest](Models/DevicePrlListRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListCurrentDevicesPrlVersionError](Errors/ListCurrentDevicesPrlVersionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountDeviceListResult&gt; ListDevicesInformation(AccountDeviceListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns information about a single device or information about all devices that match the given parameters. Returned information includes device provisioning state, service plan, MDN, MIN, and IP address.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.ListDevicesInformation(body);
    // TODO: Handle 'response' of type AccountDeviceListResult
}
catch (SdkException<ListDevicesInformationError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AccountDeviceListRequest](Models/AccountDeviceListRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountDeviceListResult](Models/AccountDeviceListResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListDevicesInformationError](Errors/ListDevicesInformationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeviceProvisioningHistoryListResult&gt;&gt; ListDevicesProvisioningHistory(DeviceProvisioningHistoryListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the provisioning history of a specified device during a specified time period.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.ListDevicesProvisioningHistory(body);
    // TODO: Handle 'response' of type IReadOnlyList<DeviceProvisioningHistoryListResult>
}
catch (SdkException<ListDevicesProvisioningHistoryError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeviceProvisioningHistoryListRequest](Models/DeviceProvisioningHistoryListRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeviceProvisioningHistoryListResult](Models/DeviceProvisioningHistoryListResult.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListDevicesProvisioningHistoryError](Errors/ListDevicesProvisioningHistoryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceUsageListResult&gt; ListDevicesUsageHistory(DeviceUsageListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the network data usage history of a device during a specified time period.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.ListDevicesUsageHistory(body);
    // TODO: Handle 'response' of type DeviceUsageListResult
}
catch (SdkException<ListDevicesUsageHistoryError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeviceUsageListRequest](Models/DeviceUsageListRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceUsageListResult](Models/DeviceUsageListResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListDevicesUsageHistoryError](Errors/ListDevicesUsageHistoryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceMismatchListResult&gt; ListDevicesWithImeiIccidMismatch(DeviceMismatchListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all 4G devices with an ICCID (SIM) that was not activated with the expected IMEI (hardware) during a specified time frame.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.ListDevicesWithImeiIccidMismatch(body);
    // TODO: Handle 'response' of type DeviceMismatchListResult
}
catch (SdkException<ListDevicesWithImeiIccidMismatchError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeviceMismatchListRequest](Models/DeviceMismatchListRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceMismatchListResult](Models/DeviceMismatchListResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListDevicesWithImeiIccidMismatchError](Errors/ListDevicesWithImeiIccidMismatchError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; MoveDevicesWithinAccountsOfProfile(MoveDeviceRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Move active devices from one billing account to another within a customer profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.MoveDevicesWithinAccountsOfProfile(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<MoveDevicesWithinAccountsOfProfileError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[MoveDeviceRequest](Models/MoveDeviceRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[MoveDevicesWithinAccountsOfProfileError](Errors/MoveDevicesWithinAccountsOfProfileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; RestoreServiceForSuspendedDevices(CarrierActionsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Restores service to one or more suspended devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.RestoreServiceForSuspendedDevices(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<RestoreServiceForSuspendedDevicesError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CarrierActionsRequest](Models/CarrierActionsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RestoreServiceForSuspendedDevicesError](Errors/RestoreServiceForSuspendedDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; RetrieveAggregateDeviceUsageHistory(DeviceAggregateUsageListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The information is returned in a callback response, so you must register a URL for DeviceUsage callback messages using the POST /callbacks API.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.RetrieveAggregateDeviceUsageHistory(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<RetrieveAggregateDeviceUsageHistoryError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeviceAggregateUsageListRequest](Models/DeviceAggregateUsageListRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RetrieveAggregateDeviceUsageHistoryError](Errors/RetrieveAggregateDeviceUsageHistoryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConnectionHistoryResult&gt; RetrieveDeviceConnectionHistory(DeviceConnectionListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Each response includes a maximum of 500 records. To obtain more records, you can call the API multiple times, adjusting the earliest value each time to start where the previous request finished.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.RetrieveDeviceConnectionHistory(body);
    // TODO: Handle 'response' of type ConnectionHistoryResult
}
catch (SdkException<RetrieveDeviceConnectionHistoryError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeviceConnectionListRequest](Models/DeviceConnectionListRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConnectionHistoryResult](Models/ConnectionHistoryResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RetrieveDeviceConnectionHistoryError](Errors/RetrieveDeviceConnectionHistoryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; SuspendServiceForDevices(CarrierActionsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Suspends service for one or more devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.SuspendServiceForDevices(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<SuspendServiceForDevicesError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CarrierActionsRequest](Models/CarrierActionsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SuspendServiceForDevicesError](Errors/SuspendServiceForDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; UpdateDeviceId(string serviceType, ChangeDeviceIdRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the identifier of a 3G or 4G device to match hardware changes made for a line of service. Use this request to transfer the line of service and the MDN to new hardware, or to change the MDN.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.UpdateDeviceId(serviceType, body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<UpdateDeviceIdError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>serviceType</code> | <code>string</code> | Identifier type. |
| <code>body</code> | <code>[ChangeDeviceIdRequest](Models/ChangeDeviceIdRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateDeviceIdError](Errors/UpdateDeviceIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; UpdateDevicesContactInformation(ContactInfoUpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends a CarrierService callback message for each device in the request when the contact information has been changed, or if there was a problem and the change could not be completed.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.UpdateDevicesContactInformation(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<UpdateDevicesContactInformationError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ContactInfoUpdateRequest](Models/ContactInfoUpdateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateDevicesContactInformationError](Errors/UpdateDevicesContactInformationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; UpdateDevicesCostCenterCode(DeviceCostCenterRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes or removes the CostCenterCode value or customer name and address (Primary Place of Use) for one or more devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.UpdateDevicesCostCenterCode(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<UpdateDevicesCostCenterCodeError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeviceCostCenterRequest](Models/DeviceCostCenterRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateDevicesCostCenterCodeError](Errors/UpdateDevicesCostCenterCodeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; UpdateDevicesCustomFields(CustomFieldsUpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends a CarrierService callback message for each device in the request when the custom fields have been changed, or if there was a problem and the change could not be completed.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.UpdateDevicesCustomFields(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<UpdateDevicesCustomFieldsError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CustomFieldsUpdateRequest](Models/CustomFieldsUpdateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateDevicesCustomFieldsError](Errors/UpdateDevicesCustomFieldsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; UpdateDevicesState(GoToStateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the provisioning state of one or more devices to a specified customer-defined service and state.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.UpdateDevicesState(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<UpdateDevicesStateError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GoToStateRequest](Models/GoToStateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateDevicesStateError](Errors/UpdateDevicesStateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; UploadActivateDevice(UploadsActivatesDeviceRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uploads and activates device identifiers and SKUs for new devices from OEMs to Verizon.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.UploadActivateDevice(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<UploadActivateDeviceError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[UploadsActivatesDeviceRequest](Models/UploadsActivatesDeviceRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UploadActivateDeviceError](Errors/UploadActivateDeviceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; UsageSegmentationLabelAssociation(AssociateLabelRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Allows you to associate your own usage segmentation label with a device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.UsageSegmentationLabelAssociation(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<UsageSegmentationLabelAssociationError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AssociateLabelRequest](Models/AssociateLabelRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UsageSegmentationLabelAssociationError](Errors/UsageSegmentationLabelAssociationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; UsageSegmentationLabelDeletion(string accountName, LabelsList labelList, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Allow customers to remove the associated label from a device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceManagement.UsageSegmentationLabelDeletion(accountName, labelList);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<UsageSegmentationLabelDeletionError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | The numeric name of the account. |
| <code>labelList</code> | <code>[LabelsList](Models/LabelsList.cs)</code> | A list of the Label IDs to remove from the exclusion list. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UsageSegmentationLabelDeletionError](Errors/UsageSegmentationLabelDeletionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceMonitoring

> Source: [DeviceMonitoring](Api/DeviceMonitoring.cs)

<details>
<summary><code>Task&lt;RequestResponse&gt; DeviceReachability(NotificationReportRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceMonitoring.DeviceReachability(body);
    // TODO: Handle 'response' of type RequestResponse
}
catch (SdkException<DeviceReachabilityError> ex)
{
    if (ex.Error.TryGetRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponse
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[NotificationReportRequest](Models/NotificationReportRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestResponse](Models/RequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeviceReachabilityError](Errors/DeviceReachabilityError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RequestResponse&gt; StopDeviceReachability(StopMonitorRequest stopreachabilitypayload, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceMonitoring.StopDeviceReachability(stopreachabilitypayload);
    // TODO: Handle 'response' of type RequestResponse
}
catch (SdkException<StopDeviceReachabilityError> ex)
{
    if (ex.Error.TryGetRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponse
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>stopreachabilitypayload</code> | <code>[StopMonitorRequest](Models/StopMonitorRequest.cs)</code> | Payload for the Stop Device Reachability monitors request. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestResponse](Models/RequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[StopDeviceReachabilityError](Errors/StopDeviceReachabilityError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceProfileManagement

> Source: [DeviceProfileManagement](Api/DeviceProfileManagement.cs)

<details>
<summary><code>Task&lt;RequestResponse&gt; ActivateDeviceThroughProfile(ActivateDeviceProfileRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uses the profile to bring the device under management.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceProfileManagement.ActivateDeviceThroughProfile(body);
    // TODO: Handle 'response' of type RequestResponse
}
catch (SdkException<ActivateDeviceThroughProfileError> ex)
{
    if (ex.Error.TryGetRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponse
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ActivateDeviceProfileRequest](Models/ActivateDeviceProfileRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestResponse](Models/RequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ActivateDeviceThroughProfileError](Errors/ActivateDeviceThroughProfileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RequestResponse&gt; ProfileToActivateDevice(ProfileRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uses the profile to activate the device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceProfileManagement.ProfileToActivateDevice(body);
    // TODO: Handle 'response' of type RequestResponse
}
catch (SdkException<ProfileToActivateDeviceError> ex)
{
    if (ex.Error.TryGetRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponse
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ProfileRequest](Models/ProfileRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestResponse](Models/RequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ProfileToActivateDeviceError](Errors/ProfileToActivateDeviceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RequestResponse&gt; ProfileToDeactivateDevice(DeactivateDeviceProfileRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uses the profile to deactivate the device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceProfileManagement.ProfileToDeactivateDevice(body);
    // TODO: Handle 'response' of type RequestResponse
}
catch (SdkException<ProfileToDeactivateDeviceError> ex)
{
    if (ex.Error.TryGetRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponse
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeactivateDeviceProfileRequest](Models/DeactivateDeviceProfileRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestResponse](Models/RequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ProfileToDeactivateDeviceError](Errors/ProfileToDeactivateDeviceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RequestResponse&gt; ProfileToSetFallbackAttribute(SetFallbackAttributeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Allows the profile to set the fallback attribute to the device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceProfileManagement.ProfileToSetFallbackAttribute(body);
    // TODO: Handle 'response' of type RequestResponse
}
catch (SdkException<ProfileToSetFallbackAttributeError> ex)
{
    if (ex.Error.TryGetRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponse
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SetFallbackAttributeRequest](Models/SetFallbackAttributeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestResponse](Models/RequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ProfileToSetFallbackAttributeError](Errors/ProfileToSetFallbackAttributeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceReports

> Source: [DeviceReports](Api/DeviceReports.cs)

<details>
<summary><code>Task&lt;AggregatedReportCallbackResult&gt; CalculateAggregatedReportAsynchronous(AggregateSessionReportRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Calculate aggregated report per day with number of sessions and usage information. User will receive an asynchronous callback for the specified list of devices (Max 10000) and date range (Max 180 days).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceReports.CalculateAggregatedReportAsynchronous(body);
    // TODO: Handle 'response' of type AggregatedReportCallbackResult
}
catch (SdkException<CalculateAggregatedReportAsynchronousError> ex)
{
    if (ex.Error.TryGetHyperPreciseLocationResult(out var error))
    {
        // TODO: Handle 'error' of type HyperPreciseLocationResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AggregateSessionReportRequest](Models/AggregateSessionReportRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AggregatedReportCallbackResult](Models/AggregatedReportCallbackResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CalculateAggregatedReportAsynchronousError](Errors/CalculateAggregatedReportAsynchronousError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AggregateSessionReport&gt; CalculateAggregatedReportSynchronous(AggregateSessionReportRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Calculate aggregated report per day with number of sessions and usage information. User will receive synchronous response for specified list of devices (Max 10) and date range (Max 180 days).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceReports.CalculateAggregatedReportSynchronous(body);
    // TODO: Handle 'response' of type AggregateSessionReport
}
catch (SdkException<CalculateAggregatedReportSynchronousError> ex)
{
    if (ex.Error.TryGetHyperPreciseLocationResult(out var error))
    {
        // TODO: Handle 'error' of type HyperPreciseLocationResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AggregateSessionReportRequest](Models/AggregateSessionReportRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AggregateSessionReport](Models/AggregateSessionReport.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CalculateAggregatedReportSynchronousError](Errors/CalculateAggregatedReportSynchronousError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SessionReport&gt; GetSessionsReport(SessionReportRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Detailed report of session duration and number of bytes transferred per day.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceReports.GetSessionsReport(body);
    // TODO: Handle 'response' of type SessionReport
}
catch (SdkException<GetSessionsReportError> ex)
{
    if (ex.Error.TryGetHyperPreciseLocationResult(out var error))
    {
        // TODO: Handle 'error' of type HyperPreciseLocationResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SessionReportRequest](Models/SessionReportRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SessionReport](Models/SessionReport.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetSessionsReportError](Errors/GetSessionsReportError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceSmsMessaging

> Source: [DeviceSmsMessaging](Api/DeviceSmsMessaging.cs)

<details>
<summary><code>Task&lt;SmsMessagesResponse&gt; GetSmsMessages(string accountName, string? next, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves queued SMS messages sent by all M2M MC devices associated with an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceSmsMessaging.GetSmsMessages(accountName, next);
    // TODO: Handle 'response' of type SmsMessagesResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | Numeric account name |
| <code>next</code> | <code>string?</code> | Continue the previous query from the pageUrl in Location Header |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SmsMessagesResponse](Models/SmsMessagesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; ListSmsMessageHistory(SmsEventHistoryRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of sms history for a given device during a specified time frame.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceSmsMessaging.ListSmsMessageHistory(body);
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SmsEventHistoryRequest](Models/SmsEventHistoryRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](Models/GioRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; SendAnSmsMessage(GiosmsSendRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends an SMS message to one device. Messages are queued on the M2M MC Platform and sent as soon as possible, but they may be delayed due to traffic and routing considerations.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceSmsMessaging.SendAnSmsMessage(body);
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GiosmsSendRequest](Models/GiosmsSendRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](Models/GioRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SuccessResponse&gt; StartSmsMessageDelivery(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Starts delivery of SMS messages for the specified account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceSmsMessaging.StartSmsMessageDelivery(accountName);
    // TODO: Handle 'response' of type SuccessResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | Numeric account name |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SuccessResponse](Models/SuccessResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceServiceManagement

> Source: [DeviceServiceManagement](Api/DeviceServiceManagement.cs)

<details>
<summary><code>Task&lt;BullseyeServiceResult&gt; GetDeviceHyperPreciseStatus(string imei, string accountNumber, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets the list of a status for hyper-precise location devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceServiceManagement.GetDeviceHyperPreciseStatus(imei, accountNumber);
    // TODO: Handle 'response' of type BullseyeServiceResult
}
catch (SdkException<GetDeviceHyperPreciseStatusError> ex)
{
    if (ex.Error.TryGetHyperPreciseLocationResult(out var error))
    {
        // TODO: Handle 'error' of type HyperPreciseLocationResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>imei</code> | <code>string</code> | The International Mobile Equipment Identifier of the device. |
| <code>accountNumber</code> | <code>string</code> | The numeric name of the account and must include leading zeroes. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BullseyeServiceResult](Models/BullseyeServiceResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetDeviceHyperPreciseStatusError](Errors/GetDeviceHyperPreciseStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BullseyeServiceResult&gt; UpdateDeviceHyperPreciseStatus(BullseyeServiceRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enable/disable hyper-precise service for a device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceServiceManagement.UpdateDeviceHyperPreciseStatus(body);
    // TODO: Handle 'response' of type BullseyeServiceResult
}
catch (SdkException<UpdateDeviceHyperPreciseStatusError> ex)
{
    if (ex.Error.TryGetHyperPreciseLocationResult(out var error))
    {
        // TODO: Handle 'error' of type HyperPreciseLocationResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[BullseyeServiceRequest](Models/BullseyeServiceRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BullseyeServiceResult](Models/BullseyeServiceResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateDeviceHyperPreciseStatusError](Errors/UpdateDeviceHyperPreciseStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DevicesLocationSubscriptions

> Source: [DevicesLocationSubscriptions](Api/DevicesLocationSubscriptions.cs)

<details>
<summary><code>Task&lt;DeviceLocationSubscription&gt; GetLocationServiceSubscriptionStatus(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This subscriptions endpoint retrieves an account's current location subscription status.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DevicesLocationSubscriptions.GetLocationServiceSubscriptionStatus(accountName);
    // TODO: Handle 'response' of type DeviceLocationSubscription
}
catch (SdkException<GetLocationServiceSubscriptionStatusError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | Account identifier in "##########-#####". |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceLocationSubscription](Models/DeviceLocationSubscription.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLocationServiceSubscriptionStatusError](Errors/GetLocationServiceSubscriptionStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; GetLocationServiceUsage(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to search for billable usage for accounts based on the provided date range.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DevicesLocationSubscriptions.GetLocationServiceUsage();
    // TODO: Handle 'response' of type object
}
catch (SdkException<GetLocationServiceUsageError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLocationServiceUsageError](Errors/GetLocationServiceUsageError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DevicesLocations

> Source: [DevicesLocations](Api/DevicesLocations.cs)

<details>
<summary><code>Task&lt;TransactionId&gt; CancelQueuedLocationReportGeneration(string accountName, string txid, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancel a queued device location report.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DevicesLocations.CancelQueuedLocationReportGeneration(accountName, txid);
    // TODO: Handle 'response' of type TransactionId
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | Account identifier in "##########-#####". |
| <code>txid</code> | <code>string</code> | Transaction ID of the report to cancel. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionId](Models/TransactionId.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AsynchronousLocationRequestResult&gt; CreateLocationReport(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Request an asynchronous device location report.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DevicesLocations.CreateLocationReport();
    // TODO: Handle 'response' of type AsynchronousLocationRequestResult
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AsynchronousLocationRequestResult](Models/AsynchronousLocationRequestResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LocationReportStatus&gt; GetLocationReportStatus(string accountName, string txid, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the current status of a requested device location report.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DevicesLocations.GetLocationReportStatus(accountName, txid);
    // TODO: Handle 'response' of type LocationReportStatus
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | Account identifier in "##########-#####". |
| <code>txid</code> | <code>string</code> | Transaction ID of the report. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LocationReportStatus](Models/LocationReportStatus.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SynchronousLocationRequestResult&gt; ListDevicesLocationsAsynchronous(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Requests the current or cached location of up to 10,000 IoT or consumer devices (phones, tablets. etc.). This request returns a synchronous transaction ID, and the location information for each device is returned asynchronously as a DeviceLocation callback message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DevicesLocations.ListDevicesLocationsAsynchronous();
    // TODO: Handle 'response' of type SynchronousLocationRequestResult
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SynchronousLocationRequestResult](Models/SynchronousLocationRequestResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Location&gt;&gt; ListDevicesLocationsSynchronous(LocationRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This locations endpoint retrieves the locations for a list of devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DevicesLocations.ListDevicesLocationsSynchronous(body);
    // TODO: Handle 'response' of type IReadOnlyList<Location>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[LocationRequest](Models/LocationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Location](Models/Location.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LocationReport&gt; RetrieveLocationReport(string accountName, string txid, int startindex, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Download a completed asynchronous device location report.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DevicesLocations.RetrieveLocationReport(accountName, txid, startindex);
    // TODO: Handle 'response' of type LocationReport
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | Account identifier in "##########-#####". |
| <code>txid</code> | <code>string</code> | Transaction ID from POST /locationreports response. |
| <code>startindex</code> | <code>int</code> | Zero-based number of the first record to return. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LocationReport](Models/LocationReport.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DiagnosticsCallbacks

> Source: [DiagnosticsCallbacks](Api/DiagnosticsCallbacks.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeviceDiagnosticsCallback&gt;&gt; GetDiagnosticsSubscriptionCallbackInfo(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to get the registered callback information of an existing diagnostics subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DiagnosticsCallbacks.GetDiagnosticsSubscriptionCallbackInfo(accountName);
    // TODO: Handle 'response' of type IReadOnlyList<DeviceDiagnosticsCallback>
}
catch (SdkException<GetDiagnosticsSubscriptionCallbackInfoError> ex)
{
    if (ex.Error.TryGetDeviceDiagnosticsResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceDiagnosticsResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | Account identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeviceDiagnosticsCallback](Models/DeviceDiagnosticsCallback.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetDiagnosticsSubscriptionCallbackInfoError](Errors/GetDiagnosticsSubscriptionCallbackInfoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceDiagnosticsCallback&gt; RegisterDiagnosticsCallbackUrl(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user update the callback HTTPS address of an existing diagnostics subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DiagnosticsCallbacks.RegisterDiagnosticsCallbackUrl();
    // TODO: Handle 'response' of type DeviceDiagnosticsCallback
}
catch (SdkException<RegisterDiagnosticsCallbackUrlError> ex)
{
    if (ex.Error.TryGetDeviceDiagnosticsResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceDiagnosticsResult
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceDiagnosticsCallback](Models/DeviceDiagnosticsCallback.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RegisterDiagnosticsCallbackUrlError](Errors/RegisterDiagnosticsCallbackUrlError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceDiagnosticsCallback&gt; UnregisterDiagnosticsCallback(string accountName, string serviceName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to delete a registered callback URL and credential.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DiagnosticsCallbacks.UnregisterDiagnosticsCallback(accountName, serviceName);
    // TODO: Handle 'response' of type DeviceDiagnosticsCallback
}
catch (SdkException<UnregisterDiagnosticsCallbackError> ex)
{
    if (ex.Error.TryGetDeviceDiagnosticsResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceDiagnosticsResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | Account identifier. |
| <code>serviceName</code> | <code>string</code> | Service name for callback notification. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceDiagnosticsCallback](Models/DeviceDiagnosticsCallback.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UnregisterDiagnosticsCallbackError](Errors/UnregisterDiagnosticsCallbackError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DiagnosticsFactoryReset

> Source: [DiagnosticsFactoryReset](Api/DiagnosticsFactoryReset.cs)

<details>
<summary><code>Task&lt;DiagnosticsObservationResult&gt; DecivesRestart(DeviceResetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Performs a device reboot or a factory reset on the modem portion of the device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DiagnosticsFactoryReset.DecivesRestart(body);
    // TODO: Handle 'response' of type DiagnosticsObservationResult
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeviceResetRequest](Models/DeviceResetRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DiagnosticsObservationResult](Models/DiagnosticsObservationResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DiagnosticsHistory

> Source: [DiagnosticsHistory](Api/DiagnosticsHistory.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;History&gt;&gt; GetDiagnosticsHistory(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows the user to get the history data.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DiagnosticsHistory.GetDiagnosticsHistory();
    // TODO: Handle 'response' of type IReadOnlyList<History>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[History](Models/History.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DiagnosticsObservations

> Source: [DiagnosticsObservations](Api/DiagnosticsObservations.cs)

<details>
<summary><code>Task&lt;DiagnosticsObservationResult&gt; StartDiagnosticsObservation(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows the user to start or change observe diagnostics.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DiagnosticsObservations.StartDiagnosticsObservation();
    // TODO: Handle 'response' of type DiagnosticsObservationResult
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DiagnosticsObservationResult](Models/DiagnosticsObservationResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DiagnosticsObservationResult&gt; StopDiagnosticsObservation(string transactionId, string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows the user to stop or reset observe diagnostics.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DiagnosticsObservations.StopDiagnosticsObservation(transactionId, accountName);
    // TODO: Handle 'response' of type DiagnosticsObservationResult
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>transactionId</code> | <code>string</code> | The ID value associated with the transaction. |
| <code>accountName</code> | <code>string</code> | The numeric account name. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DiagnosticsObservationResult](Models/DiagnosticsObservationResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DiagnosticsSettings

> Source: [DiagnosticsSettings](Api/DiagnosticsSettings.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DiagnosticObservationSetting&gt;&gt; ListDiagnosticsSettings(string accountName, string devices, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint retrieves diagnostics settings synchronously.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DiagnosticsSettings.ListDiagnosticsSettings(accountName, devices);
    // TODO: Handle 'response' of type IReadOnlyList<DiagnosticObservationSetting>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | Account identifier. |
| <code>devices</code> | <code>string</code> | Devices list formatted as "id, kind" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DiagnosticObservationSetting](Models/DiagnosticObservationSetting.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DiagnosticsSubscriptions

> Source: [DiagnosticsSubscriptions](Api/DiagnosticsSubscriptions.cs)

<details>
<summary><code>Task&lt;DiagnosticsSubscription&gt; GetDiagnosticsSubscription(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint retrieves a diagnostics subscription by account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DiagnosticsSubscriptions.GetDiagnosticsSubscription(accountName);
    // TODO: Handle 'response' of type DiagnosticsSubscription
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | Account identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DiagnosticsSubscription](Models/DiagnosticsSubscription.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## EtxAppConfiguration

> Source: [EtxAppConfiguration](Api/EtxAppConfiguration.cs)

<details>
<summary><code>Task&lt;GeoFenceConfigurationResponse&gt; CreateConfiguration(string vendorId, GeoFenceConfigurationRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint creates a new configuration in the system. The data for the new configuration should be provided as JSON in the body of the POST request. The system will return with a unique ID for the configuration, which is needed for any further manipulation (update or delete) of the configuration.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EtxAppConfiguration.CreateConfiguration(vendorId, body);
    // TODO: Handle 'response' of type GeoFenceConfigurationResponse
}
catch (SdkException<CreateConfigurationError> ex)
{
    if (ex.Error.TryGetResponseError(out var error))
    {
        // TODO: Handle 'error' of type ResponseError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vendorId</code> | <code>string</code> | The vendor's identifier |
| <code>body</code> | <code>[GeoFenceConfigurationRequest](Models/GeoFenceConfigurationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GeoFenceConfigurationResponse](Models/GeoFenceConfigurationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateConfigurationError](Errors/CreateConfigurationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteConfiguration(string id, string vendorId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint deletes a specific configuration from the system. It requires the configuration ID parameter, which was provided by the POST (create) operation.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.EtxAppConfiguration.DeleteConfiguration(id, vendorId);
}
catch (SdkException<DeleteConfigurationError> ex)
{
    if (ex.Error.TryGetResponseError(out var error))
    {
        // TODO: Handle 'error' of type ResponseError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The configuration identifier |
| <code>vendorId</code> | <code>string</code> | The vendor's identifier |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteConfigurationError](Errors/DeleteConfigurationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GeoFenceConfigurationResponse&gt; GetConfiguration(string id, string vendorId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint fetches and returns a specific configuration's details. The configuration ID parameter, which was provided when the configuration was created through the POST request, is need to retrieve the configuration details.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EtxAppConfiguration.GetConfiguration(id, vendorId);
    // TODO: Handle 'response' of type GeoFenceConfigurationResponse
}
catch (SdkException<GetConfigurationError> ex)
{
    if (ex.Error.TryGetResponseError(out var error))
    {
        // TODO: Handle 'error' of type ResponseError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The configuration identifier |
| <code>vendorId</code> | <code>string</code> | The vendor's identifier |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GeoFenceConfigurationResponse](Models/GeoFenceConfigurationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetConfigurationError](Errors/GetConfigurationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ConfigurationListItem&gt;&gt; GetConfigurationList(string vendorId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint fetches and returns the list of configurations defined by the Vendor. The list contains the configurations' identifier, name, description, and active flag. The vendor ID is provided when the configuration is created through the POST request.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EtxAppConfiguration.GetConfigurationList(vendorId);
    // TODO: Handle 'response' of type IReadOnlyList<ConfigurationListItem>
}
catch (SdkException<GetConfigurationListError> ex)
{
    if (ex.Error.TryGetResponseError(out var error))
    {
        // TODO: Handle 'error' of type ResponseError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vendorId</code> | <code>string</code> | The vendor's identifier |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ConfigurationListItem](Models/ConfigurationListItem.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetConfigurationListError](Errors/GetConfigurationListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task UpdateConfiguration(string id, string vendorId, GeoFenceConfigurationUpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint updates an existing configuration. Similar to POST, the updated data for the configuration should be provided as JSON in the body of the PUT request. The configuration ID parameter, which was provided by the POST (create) operation, is required to do any updates on the configuration.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.EtxAppConfiguration.UpdateConfiguration(id, vendorId, body);
}
catch (SdkException<UpdateConfigurationError> ex)
{
    if (ex.Error.TryGetResponseError(out var error))
    {
        // TODO: Handle 'error' of type ResponseError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The configuration identifier |
| <code>vendorId</code> | <code>string</code> | The vendor's identifier |
| <code>body</code> | <code>[GeoFenceConfigurationUpdateRequest](Models/GeoFenceConfigurationUpdateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateConfigurationError](Errors/UpdateConfigurationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## EtxRegistration

> Source: [EtxRegistration](Api/EtxRegistration.cs)

<details>
<summary><code>Task&lt;ClientPersistenceResponse&gt; GetEtxClientCertificate(EtxClientIdLookup id, string vendorId, Guid? xTransactionId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

With this API call the user can check the certificate of the device. At least one of the DeviceID, IMEI, ICCID or IMSI is required to make the call.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EtxRegistration.GetEtxClientCertificate(id, vendorId, xTransactionId);
    // TODO: Handle 'response' of type ClientPersistenceResponse
}
catch (SdkException<GetEtxClientCertificateError> ex)
{
    if (ex.Error.TryGetEtxRespondingError(out var error))
    {
        // TODO: Handle 'error' of type EtxRespondingError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>[EtxClientIdLookup](Models/EtxClientIdLookup.cs)</code> | One of the following IDs is required- DeviceID, IMEI, ICCID, IMSI. If more than one ID is provided, the API will return the certificate for the first ID found. The IDs are evaluated in the following order: DeviceID, IMEI, ICCID, IMSI. If the first provided ID is not found, the API will return an error. |
| <code>vendorId</code> | <code>string</code> | The VendorID set during the Vendor registration call. |
| <code>xTransactionId</code> | <code>Guid?</code> | Optional transaction identifier for tracing requests. If not provided, the application will generate one. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ClientPersistenceResponse](Models/ClientPersistenceResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetEtxClientCertificateError](Errors/GetEtxClientCertificateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConnectionResponse&gt; GetEtxConnectionUrl(string vendorId, Guid? xTransactionId, ConnectionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

With this API call the device or software service requests the MQTT URL for the location that it needs to connect. To determine the proper URL the device or software service needs to provide its ID (the one that was provided in the registration request), location (GPS coordinates), and whether it is on the Verizon cellular network or not.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EtxRegistration.GetEtxConnectionUrl(vendorId, xTransactionId, body);
    // TODO: Handle 'response' of type ConnectionResponse
}
catch (SdkException<GetEtxConnectionUrlError> ex)
{
    if (ex.Error.TryGetEtxRespondingError(out var error))
    {
        // TODO: Handle 'error' of type EtxRespondingError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vendorId</code> | <code>string</code> | The VendorID set during the Vendor registration call. |
| <code>xTransactionId</code> | <code>Guid?</code> | Optional transaction identifier for tracing requests. If not provided, the application will generate one. |
| <code>body</code> | <code>[ConnectionRequest](Models/ConnectionRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConnectionResponse](Models/ConnectionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetEtxConnectionUrlError](Errors/GetEtxConnectionUrlError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConnectionResponseV3&gt; GetEtxConnectionUrlMultiMec(string vendorId, Guid? xTransactionId, ConnectionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

With this API call the device or software service requests the MQTT URL for the location that it needs to connect. To determine the proper URL the device or software service needs to provide its ID (the one that was provided in the registration request), location (GPS coordinates), and whether it is on the Verizon cellular network or not.

If there are multiple MECs that serve the location of the client all options are provided in the response, and the client is free to choose which MEC they want to connect.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EtxRegistration.GetEtxConnectionUrlMultiMec(vendorId, xTransactionId, body);
    // TODO: Handle 'response' of type ConnectionResponseV3
}
catch (SdkException<GetEtxConnectionUrlMultiMecError> ex)
{
    if (ex.Error.TryGetEtxRespondingError(out var error))
    {
        // TODO: Handle 'error' of type EtxRespondingError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vendorId</code> | <code>string</code> | The VendorID set during the Vendor registration call. |
| <code>xTransactionId</code> | <code>Guid?</code> | Optional transaction identifier for tracing requests. If not provided, the application will generate one. |
| <code>body</code> | <code>[ConnectionRequest](Models/ConnectionRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConnectionResponseV3](Models/ConnectionResponseV3.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetEtxConnectionUrlMultiMecError](Errors/GetEtxConnectionUrlMultiMecError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DevicesResponse&gt;&gt; QueryEtxDevices(Guid? xTransactionId, DevicesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This API allows retrieving devices by vendor ID and optional filters. The request should include the VendorID and any filters to apply.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EtxRegistration.QueryEtxDevices(xTransactionId, body);
    // TODO: Handle 'response' of type IReadOnlyList<DevicesResponse>
}
catch (SdkException<QueryEtxDevicesError> ex)
{
    if (ex.Error.TryGetEtxRespondingError(out var error))
    {
        // TODO: Handle 'error' of type EtxRespondingError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>xTransactionId</code> | <code>Guid?</code> | Optional transaction identifier for tracing requests. If not provided, the application will generate one. |
| <code>body</code> | <code>[DevicesRequest](Models/DevicesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DevicesResponse](Models/DevicesResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryEtxDevicesError](Errors/QueryEtxDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ClientRegistrationResponse&gt; RegisterEtxClient(Guid? xTransactionId, ClientRegistrationRequestV2 body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

With this API call the user (client) registers its device or software service to the ETX system. Therefore, when a connection is initiated from the device or software service to the ETX system along with the credential provided by this registration call, then the connection will be authorized.

- The user can register multiple devices or software services, which can all be used at the same time.
- There rules set in the system that limit the type and subtype of the clients that are allowed to be registered under the VendorID. The rules are created based ont he agreement between the Vendor and Verizon.
- The user will only be able to register a limited number of devices or software services under the same VendorID. This registration limit is specified by the agreement between the Vendor and Verizon.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EtxRegistration.RegisterEtxClient(xTransactionId, body);
    // TODO: Handle 'response' of type ClientRegistrationResponse
}
catch (SdkException<RegisterEtxClientError> ex)
{
    if (ex.Error.TryGetEtxRespondingError(out var error))
    {
        // TODO: Handle 'error' of type EtxRespondingError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>xTransactionId</code> | <code>Guid?</code> | Optional transaction identifier for tracing requests. If not provided, the application will generate one. |
| <code>body</code> | <code>[ClientRegistrationRequestV2](Models/ClientRegistrationRequestV2.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ClientRegistrationResponse](Models/ClientRegistrationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RegisterEtxClientError](Errors/RegisterEtxClientError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ClientRegistrationResponse&gt; RenewEtxClientCertificate(Guid deviceId, string vendorId, Guid? xTransactionId, object? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

With this API call the user (client) can:
- renew the certificate of a device or software service in the ETX system if the original certificate has expired. If the client's certificate expired or going to expire within 30 days and new certificate will be issued. If the certificate expires more than 30 days, the current certificate will be returned to the client.
- complete its device or software service registration to the ETX system if the original registration request was not successful because of a pending certificate generation. Whenever the user receives a "client registration is pending" response (HTTP 202) from POST /clients/registration call. The client should initiate this PUT API call to finish the registration process and get the required certificate.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EtxRegistration.RenewEtxClientCertificate(deviceId, vendorId, xTransactionId, body);
    // TODO: Handle 'response' of type ClientRegistrationResponse
}
catch (SdkException<RenewEtxClientCertificateError> ex)
{
    if (ex.Error.TryGetEtxRespondingError(out var error))
    {
        // TODO: Handle 'error' of type EtxRespondingError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>deviceId</code> | <code>Guid</code> | - |
| <code>vendorId</code> | <code>string</code> | The VendorID set during the Vendor registration call. |
| <code>xTransactionId</code> | <code>Guid?</code> | Optional transaction identifier for tracing requests. If not provided, the application will generate one. |
| <code>body</code> | <code>object?</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ClientRegistrationResponse](Models/ClientRegistrationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RenewEtxClientCertificateError](Errors/RenewEtxClientCertificateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task UnregisterEtxClients(IReadOnlyList&lt;Guid&gt; deviceIDs, string vendorId, Guid? xTransactionId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

With this API call the user (client) can unregister its devices and software services from the ETX system. The unregistered devices and services will no longer be able to use the ETX Message Exchange.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.EtxRegistration.UnregisterEtxClients(deviceIDs, vendorId, xTransactionId);
}
catch (SdkException<UnregisterEtxClientsError> ex)
{
    if (ex.Error.TryGetEtxRespondingError(out var error))
    {
        // TODO: Handle 'error' of type EtxRespondingError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>deviceIDs</code> | <code>IReadOnlyList&lt;Guid&gt;</code> | The list of device IDs and software service IDs to be unregistered |
| <code>vendorId</code> | <code>string</code> | The VendorID set during the Vendor registration call. |
| <code>xTransactionId</code> | <code>Guid?</code> | Optional transaction identifier for tracing requests. If not provided, the application will generate one. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UnregisterEtxClientsError](Errors/UnregisterEtxClientsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Exclusions

> Source: [Exclusions](Api/Exclusions.cs)

<details>
<summary><code>Task&lt;GetAccountDeviceConsent&gt; DevicesLocationGetConsentAsync(string accountName, string? deviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get the consent settings for the entire account or device list in an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Exclusions.DevicesLocationGetConsentAsync(accountName, deviceId);
    // TODO: Handle 'response' of type GetAccountDeviceConsent
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | The numeric name of the account. |
| <code>deviceId</code> | <code>string?</code> | The IMEI of the device being queried |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetAccountDeviceConsent](Models/GetAccountDeviceConsent.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConsentTransactionId&gt; DevicesLocationGiveConsentAsync(AccountConsentCreate? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a consent record to use location services as an asynchronous request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Exclusions.DevicesLocationGiveConsentAsync(body);
    // TODO: Handle 'response' of type ConsentTransactionId
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AccountConsentCreate?](Models/AccountConsentCreate.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConsentTransactionId](Models/ConsentTransactionId.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConsentTransactionId&gt; DevicesLocationUpdateConsent(AccountConsentUpdate? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update the location services consent record for an entire account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Exclusions.DevicesLocationUpdateConsent(body);
    // TODO: Handle 'response' of type ConsentTransactionId
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AccountConsentUpdate?](Models/AccountConsentUpdate.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConsentTransactionId](Models/ConsentTransactionId.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceLocationSuccessResult&gt; ExcludeDevices(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This consents endpoint sets a new exclusion list.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Exclusions.ExcludeDevices();
    // TODO: Handle 'response' of type DeviceLocationSuccessResult
}
catch (SdkException<ExcludeDevicesError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceLocationSuccessResult](Models/DeviceLocationSuccessResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ExcludeDevicesError](Errors/ExcludeDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DevicesConsentResult&gt; ListExcludedDevices(string accountName, string startIndex, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This consents endpoint retrieves a list of excluded devices in an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Exclusions.ListExcludedDevices(accountName, startIndex);
    // TODO: Handle 'response' of type DevicesConsentResult
}
catch (SdkException<ListExcludedDevicesError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | Account identifier in "##########-#####". |
| <code>startIndex</code> | <code>string</code> | Zero-based number of the first record to return. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DevicesConsentResult](Models/DevicesConsentResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListExcludedDevicesError](Errors/ListExcludedDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceLocationSuccessResult&gt; RemoveDevicesFromExclusionList(string accountName, string deviceList, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes devices from the exclusion list so that they can be located with Device Location Services requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Exclusions.RemoveDevicesFromExclusionList(accountName, deviceList);
    // TODO: Handle 'response' of type DeviceLocationSuccessResult
}
catch (SdkException<RemoveDevicesFromExclusionListError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | The numeric name of the account. |
| <code>deviceList</code> | <code>string</code> | A list of the device IDs to remove from the exclusion list. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceLocationSuccessResult](Models/DeviceLocationSuccessResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RemoveDevicesFromExclusionListError](Errors/RemoveDevicesFromExclusionListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## FirmwareV1

> Source: [FirmwareV1](Api/FirmwareV1.cs)

<details>
<summary><code>Task&lt;FotaV1SuccessResult&gt; CancelScheduledFirmwareUpgrade(string accountName, string upgradeId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancel a scheduled firmware upgrade.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FirmwareV1.CancelScheduledFirmwareUpgrade(accountName, upgradeId);
    // TODO: Handle 'response' of type FotaV1SuccessResult
}
catch (SdkException<CancelScheduledFirmwareUpgradeError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | Account identifier in "##########-#####". |
| <code>upgradeId</code> | <code>string</code> | The UUID of the scheduled upgrade that you want to cancel. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV1SuccessResult](Models/FotaV1SuccessResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CancelScheduledFirmwareUpgradeError](Errors/CancelScheduledFirmwareUpgradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Firmware&gt;&gt; ListAvailableFirmware(string account, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all device firmware images available for an account, based on the devices registered to that account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FirmwareV1.ListAvailableFirmware(account);
    // TODO: Handle 'response' of type IReadOnlyList<Firmware>
}
catch (SdkException<ListAvailableFirmwareError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier in "##########-#####". |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Firmware](Models/Firmware.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListAvailableFirmwareError](Errors/ListAvailableFirmwareError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FirmwareUpgrade&gt; ListFirmwareUpgradeDetails(string accountName, string upgradeId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns information about a specified upgrade, include the target date of the upgrade, the list of devices in the upgrade, and the status of the upgrade for each device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FirmwareV1.ListFirmwareUpgradeDetails(accountName, upgradeId);
    // TODO: Handle 'response' of type FirmwareUpgrade
}
catch (SdkException<ListFirmwareUpgradeDetailsError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | Account identifier in "##########-#####". |
| <code>upgradeId</code> | <code>string</code> | The UUID of the upgrade, returned by POST /upgrades when the upgrade was scheduled. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FirmwareUpgrade](Models/FirmwareUpgrade.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListFirmwareUpgradeDetailsError](Errors/ListFirmwareUpgradeDetailsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FirmwareUpgrade&gt; ScheduleFirmwareUpgrade(FirmwareUpgradeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Schedules a firmware upgrade for devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FirmwareV1.ScheduleFirmwareUpgrade(body);
    // TODO: Handle 'response' of type FirmwareUpgrade
}
catch (SdkException<ScheduleFirmwareUpgradeError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[FirmwareUpgradeRequest](Models/FirmwareUpgradeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FirmwareUpgrade](Models/FirmwareUpgrade.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ScheduleFirmwareUpgradeError](Errors/ScheduleFirmwareUpgradeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FirmwareUpgradeChangeResult&gt; UpdateFirmwareUpgradeDevices(string accountName, string upgradeId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add or remove devices from a scheduled upgrade.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FirmwareV1.UpdateFirmwareUpgradeDevices(accountName, upgradeId);
    // TODO: Handle 'response' of type FirmwareUpgradeChangeResult
}
catch (SdkException<UpdateFirmwareUpgradeDevicesError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | Account identifier in "##########-#####". |
| <code>upgradeId</code> | <code>string</code> | The UUID of the upgrade, returned by POST /upgrades when the upgrade was scheduled. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FirmwareUpgradeChangeResult](Models/FirmwareUpgradeChangeResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateFirmwareUpgradeDevicesError](Errors/UpdateFirmwareUpgradeDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## FirmwareV3

> Source: [FirmwareV3](Api/FirmwareV3.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;FirmwarePackage&gt;&gt; ListAvailableFirmware2(string acc, FirmwareProtocol protocol, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to list the firmware of an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FirmwareV3.ListAvailableFirmware2(acc, protocol);
    // TODO: Handle 'response' of type IReadOnlyList<FirmwarePackage>
}
catch (SdkException<ListAvailableFirmware2Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>acc</code> | <code>string</code> | Account identifier. |
| <code>protocol</code> | <code>[FirmwareProtocol](Models/Enums/FirmwareProtocol.cs)</code> | Filter to retrieve a specific protocol type used. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[FirmwarePackage](Models/FirmwarePackage.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListAvailableFirmware2Error](Errors/ListAvailableFirmware2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceFirmwareVersionUpdateResult&gt; ReportDeviceFirmware(string acc, string deviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Ask a device to report its firmware version asynchronously.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FirmwareV3.ReportDeviceFirmware(acc, deviceId);
    // TODO: Handle 'response' of type DeviceFirmwareVersionUpdateResult
}
catch (SdkException<ReportDeviceFirmwareError> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>acc</code> | <code>string</code> | Account identifier. |
| <code>deviceId</code> | <code>string</code> | Device identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceFirmwareVersionUpdateResult](Models/DeviceFirmwareVersionUpdateResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ReportDeviceFirmwareError](Errors/ReportDeviceFirmwareError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceFirmwareList&gt; SynchronizeDeviceFirmware(string acc, FirmwareImei body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Synchronize ThingSpace with the FOTA server for up to 100 devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FirmwareV3.SynchronizeDeviceFirmware(acc, body);
    // TODO: Handle 'response' of type DeviceFirmwareList
}
catch (SdkException<SynchronizeDeviceFirmwareError> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>acc</code> | <code>string</code> | Account identifier. |
| <code>body</code> | <code>[FirmwareImei](Models/FirmwareImei.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceFirmwareList](Models/DeviceFirmwareList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SynchronizeDeviceFirmwareError](Errors/SynchronizeDeviceFirmwareError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GlobalReporting

> Source: [GlobalReporting](Api/GlobalReporting.cs)

<details>
<summary><code>Task&lt;ESimRequestResponse&gt; RetrieveGlobalList(ESimGlobalDeviceList body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a list of all devices associated with an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GlobalReporting.RetrieveGlobalList(body);
    // TODO: Handle 'response' of type ESimRequestResponse
}
catch (SdkException<RetrieveGlobalListError> ex)
{
    if (ex.Error.TryGetESimRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type ESimRestErrorResponse
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ESimGlobalDeviceList](Models/ESimGlobalDeviceList.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ESimRequestResponse](Models/ESimRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RetrieveGlobalListError](Errors/RetrieveGlobalListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ESimRequestResponse&gt; DeviceprovhistoryUsingPost(ESimProvhistoryRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve the provisioning history of a specific device or devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GlobalReporting.DeviceprovhistoryUsingPost(body);
    // TODO: Handle 'response' of type ESimRequestResponse
}
catch (SdkException<DeviceprovhistoryUsingPostError> ex)
{
    if (ex.Error.TryGetESimRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type ESimRestErrorResponse
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ESimProvhistoryRequest](Models/ESimProvhistoryRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ESimRequestResponse](Models/ESimRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeviceprovhistoryUsingPostError](Errors/DeviceprovhistoryUsingPostError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## HplDeviceManagement

> Source: [HplDeviceManagement](Api/HplDeviceManagement.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;HplAddDevicesRequest&gt;&gt; AddDevicesHyperPrecise(HplAddDevicesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use this API if you want to manage some device settings before you are ready to activate service for the devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.HplDeviceManagement.AddDevicesHyperPrecise(body);
    // TODO: Handle 'response' of type IReadOnlyList<HplAddDevicesRequest>
}
catch (SdkException<AddDevicesHyperPreciseError> ex)
{
    if (ex.Error.TryGetHyperPreciseLocationResult(out var error))
    {
        // TODO: Handle 'error' of type HyperPreciseLocationResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[HplAddDevicesRequest](Models/HplAddDevicesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[HplAddDevicesRequest](Models/HplAddDevicesRequest.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddDevicesHyperPreciseError](Errors/AddDevicesHyperPreciseError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## HyperPreciseLocationCallbacks

> Source: [HyperPreciseLocationCallbacks](Api/HyperPreciseLocationCallbacks.cs)

<details>
<summary><code>Task DeregisterCallback6(string accountNumber, string service, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Stops ThingSpace from sending callback messages for the specified account and listener name.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.HyperPreciseLocationCallbacks.DeregisterCallback6(accountNumber, service);
}
catch (SdkException<DeregisterCallback6Error> ex)
{
    if (ex.Error.TryGetHyperPreciseLocationResult(out var error))
    {
        // TODO: Handle 'error' of type HyperPreciseLocationResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountNumber</code> | <code>string</code> | The numeric ID of the account and must include leading zeroes. This value is indentical to `accountName`. |
| <code>service</code> | <code>string</code> | The name of the callback service that will be deleted. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeregisterCallback6Error](Errors/DeregisterCallback6Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;CallbackCreated&gt;&gt; ListRegisteredCallbacks6(string accountNumber, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Find registered callback listener for account by account number.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.HyperPreciseLocationCallbacks.ListRegisteredCallbacks6(accountNumber);
    // TODO: Handle 'response' of type IReadOnlyList<CallbackCreated>
}
catch (SdkException<ListRegisteredCallbacks6Error> ex)
{
    if (ex.Error.TryGetHyperPreciseLocationResult(out var error))
    {
        // TODO: Handle 'error' of type HyperPreciseLocationResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountNumber</code> | <code>string</code> | The numeric ID of the account and must include leading zeroes. This value is indentical to `accountName`. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[CallbackCreated](Models/CallbackCreated.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListRegisteredCallbacks6Error](Errors/ListRegisteredCallbacks6Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CallbackRegistered&gt; RegisterCallback6(string accountNumber, HyperPreciseLocationCallback body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Registers a URL at which an account receives asynchronous responses and other messages from a ThingSpace Platform callback service. The messages are REST messages. You are responsible for creating and running a listening process on your server at that URL to receive and parse the messages.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.HyperPreciseLocationCallbacks.RegisterCallback6(accountNumber, body);
    // TODO: Handle 'response' of type CallbackRegistered
}
catch (SdkException<RegisterCallback6Error> ex)
{
    if (ex.Error.TryGetHyperPreciseLocationResult(out var error))
    {
        // TODO: Handle 'error' of type HyperPreciseLocationResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountNumber</code> | <code>string</code> | A unique identifier for an account. |
| <code>body</code> | <code>[HyperPreciseLocationCallback](Models/HyperPreciseLocationCallback.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CallbackRegistered](Models/CallbackRegistered.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RegisterCallback6Error](Errors/RegisterCallback6Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## IntelligenceServiceController

> Source: [IntelligenceServiceController](Api/IntelligenceServiceController.cs)

<details>
<summary><code>Task&lt;AsynchronousRequestResultforplanner&gt; SetConnectionPlanner(GetDevicesWindowsRequestforplanner? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves available device windows for Connection Planner.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IntelligenceServiceController.SetConnectionPlanner(body);
    // TODO: Handle 'response' of type AsynchronousRequestResultforplanner
}
catch (SdkException<SetConnectionPlannerError> ex)
{
    if (ex.Error.TryGetRestErrorResponseforplanner(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponseforplanner
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GetDevicesWindowsRequestforplanner?](Models/GetDevicesWindowsRequestforplanner.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AsynchronousRequestResultforplanner](Models/AsynchronousRequestResultforplanner.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SetConnectionPlannerError](Errors/SetConnectionPlannerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetDeviceStatusesResponseforplanner&gt; StatusConnectionPlanner(GetDeviceStatusesRequestforplanner? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the device status for the Connection Planner service.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IntelligenceServiceController.StatusConnectionPlanner(body);
    // TODO: Handle 'response' of type GetDeviceStatusesResponseforplanner
}
catch (SdkException<StatusConnectionPlannerError> ex)
{
    if (ex.Error.TryGetRestErrorResponseforplanner(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponseforplanner
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GetDeviceStatusesRequestforplanner?](Models/GetDeviceStatusesRequestforplanner.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetDeviceStatusesResponseforplanner](Models/GetDeviceStatusesResponseforplanner.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[StatusConnectionPlannerError](Errors/StatusConnectionPlannerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManagingESimProfiles

> Source: [ManagingESimProfiles](Api/ManagingESimProfiles.cs)

<details>
<summary><code>Task&lt;GioRequestResponse&gt; ActivateADeviceProfile(GioProfileRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Activate a device with either a lead or local profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagingESimProfiles.ActivateADeviceProfile(body);
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GioProfileRequest](Models/GioProfileRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](Models/GioRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; DeactivateADeviceProfile(GioDeactivateDeviceProfileRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deactivate the lead or local profile. **Note:** to reactivate the profile, use the **Activate** endpoint above.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagingESimProfiles.DeactivateADeviceProfile(body);
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GioDeactivateDeviceProfileRequest](Models/GioDeactivateDeviceProfileRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](Models/GioRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; DeleteADeviceProfile(DeviceProfileRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a device profile for Global IoT Orchestration. **Note:** the profile must be deactivated first!

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagingESimProfiles.DeleteADeviceProfile(body);
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeviceProfileRequest](Models/DeviceProfileRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](Models/GioRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; DeviceSuspend(GioProfileRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Suspend all service to an eUICC device, including the lead and local profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagingESimProfiles.DeviceSuspend(body);
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GioProfileRequest](Models/GioProfileRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](Models/GioRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; DownloadADeviceProfile(DeviceProfileRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Download a Global IoT Orchestration device profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagingESimProfiles.DownloadADeviceProfile(body);
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeviceProfileRequest](Models/DeviceProfileRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](Models/GioRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; EnableADeviceProfile(DeviceProfileRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enable a device lead or local profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagingESimProfiles.EnableADeviceProfile(body);
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeviceProfileRequest](Models/DeviceProfileRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](Models/GioRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; EnableADeviceProfileForDownload(DeviceProfileRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enable the Global IoT Orchestration device profile for download.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagingESimProfiles.EnableADeviceProfileForDownload(body);
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeviceProfileRequest](Models/DeviceProfileRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](Models/GioRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; ProfileSuspend(GioProfileRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Suspend a device's Global profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagingESimProfiles.ProfileSuspend(body);
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GioProfileRequest](Models/GioProfileRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](Models/GioRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; ResumeProfile(GioProfileRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Resume service to a device with either a lead or local profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagingESimProfiles.ResumeProfile(body);
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GioProfileRequest](Models/GioProfileRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](Models/GioRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GioRequestResponse&gt; SetFallback(FallBack body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enable a fallback profile to be set.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagingESimProfiles.SetFallback(body);
    // TODO: Handle 'response' of type GioRequestResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[FallBack](Models/FallBack.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GioRequestResponse](Models/GioRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Pwn

> Source: [Pwn](Api/Pwn.cs)

<details>
<summary><code>Task&lt;ChangePwnDeviceIpAddressResponse&gt; ChangePwnDeviceIPaddress(ChangePwnDeviceIPaddressRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Pwn.ChangePwnDeviceIPaddress(body);
    // TODO: Handle 'response' of type ChangePwnDeviceIpAddressResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ChangePwnDeviceIPaddressRequest](Models/ChangePwnDeviceIPaddressRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChangePwnDeviceIpAddressResponse](Models/ChangePwnDeviceIpAddressResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChangePwnDeviceProfileResponse&gt; ChangePwnDeviceProfile(ChangePwnDeviceProfileRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Pwn.ChangePwnDeviceProfile(body);
    // TODO: Handle 'response' of type ChangePwnDeviceProfileResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ChangePwnDeviceProfileRequest](Models/ChangePwnDeviceProfileRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChangePwnDeviceProfileResponse](Models/ChangePwnDeviceProfileResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChangePwnDeviceStateResponse&gt; ChangePwnDeviceStateActivate(ChangePwnDeviceStateActivateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Pwn.ChangePwnDeviceStateActivate(body);
    // TODO: Handle 'response' of type ChangePwnDeviceStateResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ChangePwnDeviceStateActivateRequest](Models/ChangePwnDeviceStateActivateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChangePwnDeviceStateResponse](Models/ChangePwnDeviceStateResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChangePwnDeviceStateResponse&gt; ChangePwnDeviceStateDeactivate(ChangePwnDeviceStateDeactivateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Pwn.ChangePwnDeviceStateDeactivate(body);
    // TODO: Handle 'response' of type ChangePwnDeviceStateResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ChangePwnDeviceStateDeactivateRequest](Models/ChangePwnDeviceStateDeactivateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChangePwnDeviceStateResponse](Models/ChangePwnDeviceStateResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetPwnPerformanceConsentResponse&gt; GetPwnPerformanceConsent(string aname, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Pwn.GetPwnPerformanceConsent(aname);
    // TODO: Handle 'response' of type GetPwnPerformanceConsentResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>aname</code> | <code>string</code> | Account name. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetPwnPerformanceConsentResponse](Models/GetPwnPerformanceConsentResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PwnProfileList&gt; GetProfileList(string aname, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Pwn.GetProfileList(aname);
    // TODO: Handle 'response' of type PwnProfileList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>aname</code> | <code>string</code> | Account name. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PwnProfileList](Models/PwnProfileList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;KpiInfoList&gt; KpiList(string aname, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Pwn.KpiList(aname);
    // TODO: Handle 'response' of type KpiInfoList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>aname</code> | <code>string</code> | Account name. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[KpiInfoList](Models/KpiInfoList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PromotionPeriodInformation

> Source: [PromotionPeriodInformation](Api/PromotionPeriodInformation.cs)

<details>
<summary><code>Task&lt;UsageRequestResponse&gt; GetPromoDeviceAggregateUsageHistory(RequestBodyForUsage body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the aggregate usage for an account using pseudo-MDN during the promotional period using a callback.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PromotionPeriodInformation.GetPromoDeviceAggregateUsageHistory(body);
    // TODO: Handle 'response' of type UsageRequestResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[RequestBodyForUsage](Models/RequestBodyForUsage.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsageRequestResponse](Models/UsageRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ResponseToUsageQuery&gt; GetPromoDeviceUsageHistory(ARequestBodyForUsage body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the usage history of a device during the promotion period.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PromotionPeriodInformation.GetPromoDeviceUsageHistory(body);
    // TODO: Handle 'response' of type ResponseToUsageQuery
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ARequestBodyForUsage](Models/ARequestBodyForUsage.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ResponseToUsageQuery](Models/ResponseToUsageQuery.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RetrieveRatePlanList

> Source: [RetrieveRatePlanList](Api/RetrieveRatePlanList.cs)

<details>
<summary><code>Task&lt;Rateplan&gt; GetRatePlanList(string ecpdId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the rate plans and rate plan details for a profile ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RetrieveRatePlanList.GetRatePlanList(ecpdId);
    // TODO: Handle 'response' of type Rateplan
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ecpdId</code> | <code>string</code> | The Enterprise Customer Profile Database ID. This is the same as the accountName value |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Rateplan](Models/Rateplan.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RetrieveTheTriggers

> Source: [RetrieveTheTriggers](Api/RetrieveTheTriggers.cs)

<details>
<summary><code>Task&lt;TriggerValueResponse&gt; GetAllAvailableTriggers(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves all of the available triggers for pseudo-MDN.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RetrieveTheTriggers.GetAllAvailableTriggers();
    // TODO: Handle 'response' of type TriggerValueResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TriggerValueResponse](Models/TriggerValueResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TriggerValueResponse&gt; GetAllTriggersByAccountName(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve the triggers associated with an account name.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RetrieveTheTriggers.GetAllTriggersByAccountName(accountName);
    // TODO: Handle 'response' of type TriggerValueResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | The account name |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TriggerValueResponse](Models/TriggerValueResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TriggerValueResponse2&gt; GetAllTriggersByTriggerCategory(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves all of the triggers for the specified account associated with the PromoAlert category

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RetrieveTheTriggers.GetAllTriggersByTriggerCategory();
    // TODO: Handle 'response' of type TriggerValueResponse2
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TriggerValueResponse2](Models/TriggerValueResponse2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TriggerValueResponse2&gt; GetTriggersById(string triggerId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrives a specific trigger by its ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RetrieveTheTriggers.GetTriggersById(triggerId);
    // TODO: Handle 'response' of type TriggerValueResponse2
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>triggerId</code> | <code>string</code> | The ID of a specific trigger |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TriggerValueResponse2](Models/TriggerValueResponse2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SimActions

> Source: [SimActions](Api/SimActions.cs)

<details>
<summary><code>Task&lt;ESimRequestResponse&gt; Newactivatecode(ESimProfileRequest2 body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

System assign a new activation code to reactivate a deactivated device. **Note:** the previously assigned ICCID must be used to request a new activation code.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimActions.Newactivatecode(body);
    // TODO: Handle 'response' of type ESimRequestResponse
}
catch (SdkException<NewactivatecodeError> ex)
{
    if (ex.Error.TryGetESimRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type ESimRestErrorResponse
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ESimProfileRequest2](Models/ESimProfileRequest2.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ESimRequestResponse](Models/ESimRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[NewactivatecodeError](Errors/NewactivatecodeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ESimRequestResponse&gt; SetactivateUsingPost(ESimProfileRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uses the profile to activate the SIM.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimActions.SetactivateUsingPost(body);
    // TODO: Handle 'response' of type ESimRequestResponse
}
catch (SdkException<SetactivateUsingPostError> ex)
{
    if (ex.Error.TryGetESimRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type ESimRestErrorResponse
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ESimProfileRequest](Models/ESimProfileRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ESimRequestResponse](Models/ESimRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SetactivateUsingPostError](Errors/SetactivateUsingPostError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ESimRequestResponse&gt; SetdeactivateUsingPost(ProfileRequest2 body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uses the profile to deactivate the SIM.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimActions.SetdeactivateUsingPost(body);
    // TODO: Handle 'response' of type ESimRequestResponse
}
catch (SdkException<SetdeactivateUsingPostError> ex)
{
    if (ex.Error.TryGetESimRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type ESimRestErrorResponse
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ProfileRequest2](Models/ProfileRequest2.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ESimRequestResponse](Models/ESimRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SetdeactivateUsingPostError](Errors/SetdeactivateUsingPostError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SimSecureForIoTLicenses

> Source: [SimSecureForIoTLicenses](Api/SimSecureForIoTLicenses.cs)

<details>
<summary><code>Task&lt;SecuritySuccessResult&gt; AssignLicenseToDevices(string? xRequestId, AssignLicenseRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Assigns SIM-Secure for IoT licenses to SIMs.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimSecureForIoTLicenses.AssignLicenseToDevices(xRequestId, body);
    // TODO: Handle 'response' of type SecuritySuccessResult
}
catch (SdkException<AssignLicenseToDevicesError> ex)
{
    if (ex.Error.TryGetSecurityResult(out var error))
    {
        // TODO: Handle 'error' of type SecurityResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>xRequestId</code> | <code>string?</code> | Transaction Id. |
| <code>body</code> | <code>[AssignLicenseRequest](Models/AssignLicenseRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SecuritySuccessResult](Models/SecuritySuccessResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AssignLicenseToDevicesError](Errors/AssignLicenseToDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SecuritySuccessResult&gt; UnassignLicenseToDevices(string xRequestId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Unassigns SIM-Secure for IoT Flexible and Flexible Bundle license from SIMs.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SimSecureForIoTLicenses.UnassignLicenseToDevices(xRequestId);
    // TODO: Handle 'response' of type SecuritySuccessResult
}
catch (SdkException<UnassignLicenseToDevicesError> ex)
{
    if (ex.Error.TryGetSecurityResult(out var error))
    {
        // TODO: Handle 'error' of type SecurityResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>xRequestId</code> | <code>string</code> | Transaction Id. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SecuritySuccessResult](Models/SecuritySuccessResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UnassignLicenseToDevicesError](Errors/UnassignLicenseToDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Sms

> Source: [Sms](Api/Sms.cs)

<details>
<summary><code>Task&lt;SmsMessagesQueryResult&gt; ListDevicesSmsMessages(string aname, long? next, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

When HTTP status is 202, a URL will be returned in the Location header of the form /sms/{aname}/history?next={token}. This URL can be used to request the next set of messages.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Sms.ListDevicesSmsMessages(aname, next);
    // TODO: Handle 'response' of type SmsMessagesQueryResult
}
catch (SdkException<ListDevicesSmsMessagesError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>aname</code> | <code>string</code> | Account name. |
| <code>next</code> | <code>long?</code> | Continue the previous query from the URL in Location Header. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SmsMessagesQueryResult](Models/SmsMessagesQueryResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListDevicesSmsMessagesError](Errors/ListDevicesSmsMessagesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; SendSmsToDevice(SmsSendRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The messages are queued on the ThingSpace Platform and sent as soon as possible, but they may be delayed due to traffic and routing considerations.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Sms.SendSmsToDevice(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<SendSmsToDeviceError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SmsSendRequest](Models/SmsSendRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SendSmsToDeviceError](Errors/SendSmsToDeviceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConnectivityManagementSuccessResult&gt; StartQueuedSmsDelivery(string aname, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Tells the ThingSpace Platform to start sending mobile-originated SMS messages through the EnhancedConnectivityService callback service. SMS messages from devices are queued until they are retrieved by your application, either by callback or synchronously with GET /sms/{accountName}/history.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Sms.StartQueuedSmsDelivery(aname);
    // TODO: Handle 'response' of type ConnectivityManagementSuccessResult
}
catch (SdkException<StartQueuedSmsDeliveryError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>aname</code> | <code>string</code> | Account name. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConnectivityManagementSuccessResult](Models/ConnectivityManagementSuccessResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[StartQueuedSmsDeliveryError](Errors/StartQueuedSmsDeliveryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SensorInsightsDeviceProfile

> Source: [SensorInsightsDeviceProfile](Api/SensorInsightsDeviceProfile.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DtoProfileResponse&gt;&gt; CreateAProfile(DtoConfigurationProfile body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a device profile

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsDeviceProfile.CreateAProfile(body);
    // TODO: Handle 'response' of type IReadOnlyList<DtoProfileResponse>
}
catch (SdkException<CreateAProfileError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoConfigurationProfile](Models/DtoConfigurationProfile.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DtoProfileResponse](Models/DtoProfileResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateAProfileError](Errors/CreateAProfileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DtoProfileResponse&gt;&gt; DeleteAProfile(DtoConfigurationProfileDelete deleterequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a device profile

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsDeviceProfile.DeleteAProfile(deleterequest);
    // TODO: Handle 'response' of type IReadOnlyList<DtoProfileResponse>
}
catch (SdkException<DeleteAProfileError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>deleterequest</code> | <code>[DtoConfigurationProfileDelete](Models/DtoConfigurationProfileDelete.cs)</code> | payload for the delete request |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DtoProfileResponse](Models/DtoProfileResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteAProfileError](Errors/DeleteAProfileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DtoProfileResponse&gt;&gt; QueryAProfile(ResourceResourceQuery body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a device profile for an individual device

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsDeviceProfile.QueryAProfile(body);
    // TODO: Handle 'response' of type IReadOnlyList<DtoProfileResponse>
}
catch (SdkException<QueryAProfileError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ResourceResourceQuery](Models/ResourceResourceQuery.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DtoProfileResponse](Models/DtoProfileResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryAProfileError](Errors/QueryAProfileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DtoProfileResponse&gt;&gt; UpdateAProfile(DtoConfigurationProfilePath body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Partially update a device profile

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsDeviceProfile.UpdateAProfile(body);
    // TODO: Handle 'response' of type IReadOnlyList<DtoProfileResponse>
}
catch (SdkException<UpdateAProfileError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoConfigurationProfilePath](Models/DtoConfigurationProfilePath.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DtoProfileResponse](Models/DtoProfileResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateAProfileError](Errors/UpdateAProfileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SensorInsightsDevices

> Source: [SensorInsightsDevices](Api/SensorInsightsDevices.cs)

<details>
<summary><code>Task&lt;DtoDeviceActionSetResponse&gt; SensorInsightsDeviceActionSetRequest(DmV1DevicesActionsSetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsDevices.SensorInsightsDeviceActionSetRequest(body);
    // TODO: Handle 'response' of type DtoDeviceActionSetResponse
}
catch (SdkException<SensorInsightsDeviceActionSetRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DmV1DevicesActionsSetRequest](Models/AnyOf/DmV1DevicesActionsSetRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DtoDeviceActionSetResponse](Models/DtoDeviceActionSetResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsDeviceActionSetRequestError](Errors/SensorInsightsDeviceActionSetRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DtoLastReportedTimeResponse&gt; SensorInsightsLastReportedTimeRequest(DtoLastReportedTimeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsDevices.SensorInsightsLastReportedTimeRequest(body);
    // TODO: Handle 'response' of type DtoLastReportedTimeResponse
}
catch (SdkException<SensorInsightsLastReportedTimeRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoLastReportedTimeRequest](Models/DtoLastReportedTimeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DtoLastReportedTimeResponse](Models/DtoLastReportedTimeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsLastReportedTimeRequestError](Errors/SensorInsightsLastReportedTimeRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;UserDeviceExperienceHistory&gt;&gt; SensorInsightsListDeviceExperienceHistoryRequest(DtoListDeviceExperienceHistoryRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsDevices.SensorInsightsListDeviceExperienceHistoryRequest(body);
    // TODO: Handle 'response' of type IReadOnlyList<UserDeviceExperienceHistory>
}
catch (SdkException<SensorInsightsListDeviceExperienceHistoryRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoListDeviceExperienceHistoryRequest](Models/DtoListDeviceExperienceHistoryRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[UserDeviceExperienceHistory](Models/UserDeviceExperienceHistory.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsListDeviceExperienceHistoryRequestError](Errors/SensorInsightsListDeviceExperienceHistoryRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DtoExpandedDeviceResponse&gt;&gt; SensorInsightsListDevicesRequest(DtoListDevicesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsDevices.SensorInsightsListDevicesRequest(body);
    // TODO: Handle 'response' of type IReadOnlyList<DtoExpandedDeviceResponse>
}
catch (SdkException<SensorInsightsListDevicesRequestError> ex)
{
    if (ex.Error.TryGetManagementError(out var error))
    {
        // TODO: Handle 'error' of type ManagementError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoListDevicesRequest](Models/DtoListDevicesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DtoExpandedDeviceResponse](Models/DtoExpandedDeviceResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsListDevicesRequestError](Errors/SensorInsightsListDevicesRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;UserNetworkExperienceHistory&gt;&gt; SensorInsightsListNetworkExperienceHistoryRequest(DtoListNetworkExperienceHistoryRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsDevices.SensorInsightsListNetworkExperienceHistoryRequest(body);
    // TODO: Handle 'response' of type IReadOnlyList<UserNetworkExperienceHistory>
}
catch (SdkException<SensorInsightsListNetworkExperienceHistoryRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoListNetworkExperienceHistoryRequest](Models/DtoListNetworkExperienceHistoryRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[UserNetworkExperienceHistory](Models/UserNetworkExperienceHistory.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsListNetworkExperienceHistoryRequestError](Errors/SensorInsightsListNetworkExperienceHistoryRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ResourceDevice&gt; SensorInsightsPatchDeviceRequest(DtoPatchDeviceRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsDevices.SensorInsightsPatchDeviceRequest(body);
    // TODO: Handle 'response' of type ResourceDevice
}
catch (SdkException<SensorInsightsPatchDeviceRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoPatchDeviceRequest](Models/DtoPatchDeviceRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ResourceDevice](Models/ResourceDevice.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsPatchDeviceRequestError](Errors/SensorInsightsPatchDeviceRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SensorInsightsGateways

> Source: [SensorInsightsGateways](Api/SensorInsightsGateways.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ResourceDevice&gt;&gt; SensorInsightsListGatewayDevicesRequest(DtoListDevicesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsGateways.SensorInsightsListGatewayDevicesRequest(body);
    // TODO: Handle 'response' of type IReadOnlyList<ResourceDevice>
}
catch (SdkException<SensorInsightsListGatewayDevicesRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoListDevicesRequest](Models/DtoListDevicesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ResourceDevice](Models/ResourceDevice.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsListGatewayDevicesRequestError](Errors/SensorInsightsListGatewayDevicesRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SensorInsightsHealthScore

> Source: [SensorInsightsHealthScore](Api/SensorInsightsHealthScore.cs)

<details>
<summary><code>Task&lt;DtoGetNetworkHealthScoreResponse&gt; SensorInsightsGetNetworkHealthScoreResponse(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsHealthScore.SensorInsightsGetNetworkHealthScoreResponse();
    // TODO: Handle 'response' of type DtoGetNetworkHealthScoreResponse
}
catch (SdkException<SensorInsightsGetNetworkHealthScoreResponseError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DtoGetNetworkHealthScoreResponse](Models/DtoGetNetworkHealthScoreResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsGetNetworkHealthScoreResponseError](Errors/SensorInsightsGetNetworkHealthScoreResponseError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DtoHealthScoreSummary&gt; SensorInsightsHealthScoreSummary(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsHealthScore.SensorInsightsHealthScoreSummary();
    // TODO: Handle 'response' of type DtoHealthScoreSummary
}
catch (SdkException<SensorInsightsHealthScoreSummaryError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DtoHealthScoreSummary](Models/DtoHealthScoreSummary.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsHealthScoreSummaryError](Errors/SensorInsightsHealthScoreSummaryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SensorInsightsNotificationGroups

> Source: [SensorInsightsNotificationGroups](Api/SensorInsightsNotificationGroups.cs)

<details>
<summary><code>Task SensorInsightsAddUsersToNotificationGroupRequest(DtoAddUsersToNotificationGroupRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.SensorInsightsNotificationGroups.SensorInsightsAddUsersToNotificationGroupRequest(body);
}
catch (SdkException<SensorInsightsAddUsersToNotificationGroupRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoAddUsersToNotificationGroupRequest](Models/DtoAddUsersToNotificationGroupRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsAddUsersToNotificationGroupRequestError](Errors/SensorInsightsAddUsersToNotificationGroupRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DtoNotificationGroupResponseEntity&gt; SensorInsightsCreateNotificationGroupRequest(DtoCreateNotificationGroupRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsNotificationGroups.SensorInsightsCreateNotificationGroupRequest(body);
    // TODO: Handle 'response' of type DtoNotificationGroupResponseEntity
}
catch (SdkException<SensorInsightsCreateNotificationGroupRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoCreateNotificationGroupRequest](Models/DtoCreateNotificationGroupRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DtoNotificationGroupResponseEntity](Models/DtoNotificationGroupResponseEntity.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsCreateNotificationGroupRequestError](Errors/SensorInsightsCreateNotificationGroupRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SensorInsightsDeleteNotificationGroup(DtoDeleteNotificationGroupRequest payload, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.SensorInsightsNotificationGroups.SensorInsightsDeleteNotificationGroup(payload);
}
catch (SdkException<SensorInsightsDeleteNotificationGroupError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>payload</code> | <code>[DtoDeleteNotificationGroupRequest](Models/DtoDeleteNotificationGroupRequest.cs)</code> | Payload for the delete request. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsDeleteNotificationGroupError](Errors/SensorInsightsDeleteNotificationGroupError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DtoNotificationGroupResponseEntity&gt;&gt; SensorInsightsListNotificationGroupRequest(DtoListNotificationGroupRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsNotificationGroups.SensorInsightsListNotificationGroupRequest(body);
    // TODO: Handle 'response' of type IReadOnlyList<DtoNotificationGroupResponseEntity>
}
catch (SdkException<SensorInsightsListNotificationGroupRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoListNotificationGroupRequest](Models/DtoListNotificationGroupRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DtoNotificationGroupResponseEntity](Models/DtoNotificationGroupResponseEntity.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsListNotificationGroupRequestError](Errors/SensorInsightsListNotificationGroupRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SensorInsightsRemoveUsersFromNotificationGroupRequest(DtoRemoveUsersFromNotificationGroupRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.SensorInsightsNotificationGroups.SensorInsightsRemoveUsersFromNotificationGroupRequest(body);
}
catch (SdkException<SensorInsightsRemoveUsersFromNotificationGroupRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoRemoveUsersFromNotificationGroupRequest](Models/DtoRemoveUsersFromNotificationGroupRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsRemoveUsersFromNotificationGroupRequestError](Errors/SensorInsightsRemoveUsersFromNotificationGroupRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DtoNotificationGroupResponseEntity&gt; SensorInsightsUpdateNotificationGroupRequest(DtoUpdateNotificationGroupRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsNotificationGroups.SensorInsightsUpdateNotificationGroupRequest(body);
    // TODO: Handle 'response' of type DtoNotificationGroupResponseEntity
}
catch (SdkException<SensorInsightsUpdateNotificationGroupRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoUpdateNotificationGroupRequest](Models/DtoUpdateNotificationGroupRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DtoNotificationGroupResponseEntity](Models/DtoNotificationGroupResponseEntity.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsUpdateNotificationGroupRequestError](Errors/SensorInsightsUpdateNotificationGroupRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SensorInsightsRules

> Source: [SensorInsightsRules](Api/SensorInsightsRules.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ResourceRule&gt;&gt; SensorInsightsListRulesRequest(DtoListRulesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsRules.SensorInsightsListRulesRequest(body);
    // TODO: Handle 'response' of type IReadOnlyList<ResourceRule>
}
catch (SdkException<SensorInsightsListRulesRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoListRulesRequest](Models/DtoListRulesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ResourceRule](Models/ResourceRule.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsListRulesRequestError](Errors/SensorInsightsListRulesRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ResourceRule&gt; SensorInsightsOverwriteRuleRequest(DtoOverwriteRuleRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsRules.SensorInsightsOverwriteRuleRequest(body);
    // TODO: Handle 'response' of type ResourceRule
}
catch (SdkException<SensorInsightsOverwriteRuleRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoOverwriteRuleRequest](Models/DtoOverwriteRuleRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ResourceRule](Models/ResourceRule.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsOverwriteRuleRequestError](Errors/SensorInsightsOverwriteRuleRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SensorInsightsSensors

> Source: [SensorInsightsSensors](Api/SensorInsightsSensors.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ResourceDevice&gt;&gt; SensorInsightsListSensorDevicesRequest(DtoListSensorDevicesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsSensors.SensorInsightsListSensorDevicesRequest(body);
    // TODO: Handle 'response' of type IReadOnlyList<ResourceDevice>
}
catch (SdkException<SensorInsightsListSensorDevicesRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoListSensorDevicesRequest](Models/DtoListSensorDevicesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ResourceDevice](Models/ResourceDevice.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsListSensorDevicesRequestError](Errors/SensorInsightsListSensorDevicesRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SensorInsightsOffBoardSensorRequest(DtoOffBoardSensorRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.SensorInsightsSensors.SensorInsightsOffBoardSensorRequest(body);
}
catch (SdkException<SensorInsightsOffBoardSensorRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoOffBoardSensorRequest](Models/DtoOffBoardSensorRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsOffBoardSensorRequestError](Errors/SensorInsightsOffBoardSensorRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SensorInsightsOnBoardSensorRequest(DtoOnBoardSensorRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.SensorInsightsSensors.SensorInsightsOnBoardSensorRequest(body);
}
catch (SdkException<SensorInsightsOnBoardSensorRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoOnBoardSensorRequest](Models/DtoOnBoardSensorRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsOnBoardSensorRequestError](Errors/SensorInsightsOnBoardSensorRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DtoSensorOffBoardingStatusResponse&gt; SensorInsightsSensorOffBoardingStatusRequest(DtoSensorOffBoardStatusRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsSensors.SensorInsightsSensorOffBoardingStatusRequest(body);
    // TODO: Handle 'response' of type DtoSensorOffBoardingStatusResponse
}
catch (SdkException<SensorInsightsSensorOffBoardingStatusRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoSensorOffBoardStatusRequest](Models/DtoSensorOffBoardStatusRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DtoSensorOffBoardingStatusResponse](Models/DtoSensorOffBoardingStatusResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsSensorOffBoardingStatusRequestError](Errors/SensorInsightsSensorOffBoardingStatusRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DtoSensorOnBoardingStatusResponse&gt; SensorInsightsSensorOnBoardStatusRequest(DtoSensorOnBoardStatusRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsSensors.SensorInsightsSensorOnBoardStatusRequest(body);
    // TODO: Handle 'response' of type DtoSensorOnBoardingStatusResponse
}
catch (SdkException<SensorInsightsSensorOnBoardStatusRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoSensorOnBoardStatusRequest](Models/DtoSensorOnBoardStatusRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DtoSensorOnBoardingStatusResponse](Models/DtoSensorOnBoardingStatusResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsSensorOnBoardStatusRequestError](Errors/SensorInsightsSensorOnBoardStatusRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SensorInsightsSmartAlertMetrics

> Source: [SensorInsightsSmartAlertMetrics](Api/SensorInsightsSmartAlertMetrics.cs)

<details>
<summary><code>Task&lt;DtoQueryMetricsResponse&gt; Sensorinsightsmetricsquery(DtoQueryMetrics body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get Device Alerts for the most recent daily period, up to 30 days.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsSmartAlertMetrics.Sensorinsightsmetricsquery(body);
    // TODO: Handle 'response' of type DtoQueryMetricsResponse
}
catch (SdkException<SensorinsightsmetricsqueryError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoQueryMetrics](Models/DtoQueryMetrics.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DtoQueryMetricsResponse](Models/DtoQueryMetricsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorinsightsmetricsqueryError](Errors/SensorinsightsmetricsqueryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SensorInsightsSmartAlerts

> Source: [SensorInsightsSmartAlerts](Api/SensorInsightsSmartAlerts.cs)

<details>
<summary><code>Task&lt;UserSmartAlert&gt; SensorInsightsBulkUpdate(DtoBulkUpdate body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsSmartAlerts.SensorInsightsBulkUpdate(body);
    // TODO: Handle 'response' of type UserSmartAlert
}
catch (SdkException<SensorInsightsBulkUpdateError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoBulkUpdate](Models/DtoBulkUpdate.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserSmartAlert](Models/UserSmartAlert.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsBulkUpdateError](Errors/SensorInsightsBulkUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;UserSmartAlert&gt;&gt; SensorInsightsListSmartAlertsRequest(DtoListSmartAlertsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsSmartAlerts.SensorInsightsListSmartAlertsRequest(body);
    // TODO: Handle 'response' of type IReadOnlyList<UserSmartAlert>
}
catch (SdkException<SensorInsightsListSmartAlertsRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoListSmartAlertsRequest](Models/DtoListSmartAlertsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[UserSmartAlert](Models/UserSmartAlert.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsListSmartAlertsRequestError](Errors/SensorInsightsListSmartAlertsRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserSmartAlert&gt; SensorInsightsPatchSmartAlertRequest(DtoPatchSmartAlertRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsSmartAlerts.SensorInsightsPatchSmartAlertRequest(body);
    // TODO: Handle 'response' of type UserSmartAlert
}
catch (SdkException<SensorInsightsPatchSmartAlertRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoPatchSmartAlertRequest](Models/DtoPatchSmartAlertRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserSmartAlert](Models/UserSmartAlert.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsPatchSmartAlertRequestError](Errors/SensorInsightsPatchSmartAlertRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SensorInsightsUsers

> Source: [SensorInsightsUsers](Api/SensorInsightsUsers.cs)

<details>
<summary><code>Task&lt;ResourceUser&gt; SensorInsightsCreateUserRequest(DtoCreateUserRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsUsers.SensorInsightsCreateUserRequest(body);
    // TODO: Handle 'response' of type ResourceUser
}
catch (SdkException<SensorInsightsCreateUserRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoCreateUserRequest](Models/DtoCreateUserRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ResourceUser](Models/ResourceUser.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsCreateUserRequestError](Errors/SensorInsightsCreateUserRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SensorInsightsDeleteUser(DtoDeleteUserRequest deleterequestpayload, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.SensorInsightsUsers.SensorInsightsDeleteUser(deleterequestpayload);
}
catch (SdkException<SensorInsightsDeleteUserError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>deleterequestpayload</code> | <code>[DtoDeleteUserRequest](Models/DtoDeleteUserRequest.cs)</code> | Payload for the delete user request. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsDeleteUserError](Errors/SensorInsightsDeleteUserError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ResourceUser&gt;&gt; SensorInsightsListUserRequest(DtoListUserRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsUsers.SensorInsightsListUserRequest(body);
    // TODO: Handle 'response' of type IReadOnlyList<ResourceUser>
}
catch (SdkException<SensorInsightsListUserRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoListUserRequest](Models/DtoListUserRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ResourceUser](Models/ResourceUser.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsListUserRequestError](Errors/SensorInsightsListUserRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ResourceUser&gt; SensorInsightsUpdateUserRequest(DtoUpdateUserRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SensorInsightsUsers.SensorInsightsUpdateUserRequest(body);
    // TODO: Handle 'response' of type ResourceUser
}
catch (SdkException<SensorInsightsUpdateUserRequestError> ex)
{
    if (ex.Error.TryGetManagementError400(out var error))
    {
        // TODO: Handle 'error' of type ManagementError400
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DtoUpdateUserRequest](Models/DtoUpdateUserRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ResourceUser](Models/ResourceUser.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SensorInsightsUpdateUserRequestError](Errors/SensorInsightsUpdateUserRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ServerLogging

> Source: [ServerLogging](Api/ServerLogging.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;CheckInHistoryItem&gt;&gt; GetDeviceCheckInHistory(string account, string deviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Check-in history can be retrieved for any device belonging to the account, not necessarily with logging enabled.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServerLogging.GetDeviceCheckInHistory(account, deviceId);
    // TODO: Handle 'response' of type IReadOnlyList<CheckInHistoryItem>
}
catch (SdkException<GetDeviceCheckInHistoryError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |
| <code>deviceId</code> | <code>string</code> | Device IMEI identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[CheckInHistoryItem](Models/CheckInHistoryItem.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetDeviceCheckInHistoryError](Errors/GetDeviceCheckInHistoryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ServicePlans

> Source: [ServicePlans](Api/ServicePlans.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ServicePlan&gt;&gt; ListAccountServicePlans(string aname, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all data service plans that are associated with a specified billing account. When you send a request to /devices/actions/activate to activate a line of service you must specify the code for one of the service plans associated with your account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServicePlans.ListAccountServicePlans(aname);
    // TODO: Handle 'response' of type IReadOnlyList<ServicePlan>
}
catch (SdkException<ListAccountServicePlansError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>aname</code> | <code>string</code> | Account name. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ServicePlan](Models/ServicePlan.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListAccountServicePlansError](Errors/ListAccountServicePlansError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SessionManagement

> Source: [SessionManagement](Api/SessionManagement.cs)

<details>
<summary><code>Task&lt;LogOutRequest&gt; EndConnectivityManagementSession(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Ends a Connectivity Management session.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SessionManagement.EndConnectivityManagementSession();
    // TODO: Handle 'response' of type LogOutRequest
}
catch (SdkException<EndConnectivityManagementSessionError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LogOutRequest](Models/LogOutRequest.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EndConnectivityManagementSessionError](Errors/EndConnectivityManagementSessionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SessionResetPasswordResult&gt; ResetConnectivityManagementPassword(SessionResetPasswordRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The new password is effective immediately. Passwords do not expire, but Verizon recommends changing your password every 90 days.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SessionManagement.ResetConnectivityManagementPassword(body);
    // TODO: Handle 'response' of type SessionResetPasswordResult
}
catch (SdkException<ResetConnectivityManagementPasswordError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SessionResetPasswordRequest](Models/SessionResetPasswordRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SessionResetPasswordResult](Models/SessionResetPasswordResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ResetConnectivityManagementPasswordError](Errors/ResetConnectivityManagementPasswordError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LogInResult&gt; StartConnectivityManagementSession(LogInRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Initiates a Connectivity Management session and returns a VZ-M2M session token that is required in subsequent API requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SessionManagement.StartConnectivityManagementSession(body);
    // TODO: Handle 'response' of type LogInResult
}
catch (SdkException<StartConnectivityManagementSessionError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[LogInRequest?](Models/LogInRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LogInResult](Models/LogInResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[StartConnectivityManagementSessionError](Errors/StartConnectivityManagementSessionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementCallbacksV1

> Source: [SoftwareManagementCallbacksV1](Api/SoftwareManagementCallbacksV1.cs)

<details>
<summary><code>Task DeregisterCallback3(string account, CallbackService service, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deregisters the callback endpoint and stops ThingSpace from sending FOTA callback messages for the specified account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.SoftwareManagementCallbacksV1.DeregisterCallback3(account, service);
}
catch (SdkException<DeregisterCallback3Error> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier in "##########-#####". |
| <code>service</code> | <code>[CallbackService](Models/Enums/CallbackService.cs)</code> | Callback type. Must be 'Fota' for Software Management Services API. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeregisterCallback3Error](Errors/DeregisterCallback3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;RegisteredCallbacks&gt;&gt; ListRegisteredCallbacks3(string account, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the name and endpoint URL of the callback listening services registered for a given account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementCallbacksV1.ListRegisteredCallbacks3(account);
    // TODO: Handle 'response' of type IReadOnlyList<RegisteredCallbacks>
}
catch (SdkException<ListRegisteredCallbacks3Error> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier in "##########-#####". |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[RegisteredCallbacks](Models/RegisteredCallbacks.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListRegisteredCallbacks3Error](Errors/ListRegisteredCallbacks3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FotaV1CallbackRegistrationResult&gt; RegisterCallback3(string account, FotaV1CallbackRegistrationRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Registers a URL to receive RESTful messages from a callback service when new firmware versions are available and when upgrades start and finish.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementCallbacksV1.RegisterCallback3(account, body);
    // TODO: Handle 'response' of type FotaV1CallbackRegistrationResult
}
catch (SdkException<RegisterCallback3Error> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier in "##########-#####". |
| <code>body</code> | <code>[FotaV1CallbackRegistrationRequest](Models/FotaV1CallbackRegistrationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV1CallbackRegistrationResult](Models/FotaV1CallbackRegistrationResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RegisterCallback3Error](Errors/RegisterCallback3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementCallbacksV2

> Source: [SoftwareManagementCallbacksV2](Api/SoftwareManagementCallbacksV2.cs)

<details>
<summary><code>Task&lt;FotaV2SuccessResult&gt; DeregisterCallback4(string account, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to delete a previously registered callback URL.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementCallbacksV2.DeregisterCallback4(account);
    // TODO: Handle 'response' of type FotaV2SuccessResult
}
catch (SdkException<DeregisterCallback4Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV2SuccessResult](Models/FotaV2SuccessResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeregisterCallback4Error](Errors/DeregisterCallback4Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CallbackSummary&gt; ListRegisteredCallbacks4(string account, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to get the registered callback information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementCallbacksV2.ListRegisteredCallbacks4(account);
    // TODO: Handle 'response' of type CallbackSummary
}
catch (SdkException<ListRegisteredCallbacks4Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CallbackSummary](Models/CallbackSummary.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListRegisteredCallbacks4Error](Errors/ListRegisteredCallbacks4Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FotaV2CallbackRegistrationResult&gt; RegisterCallback4(string account, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to create the HTTPS callback address.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementCallbacksV2.RegisterCallback4(account);
    // TODO: Handle 'response' of type FotaV2CallbackRegistrationResult
}
catch (SdkException<RegisterCallback4Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV2CallbackRegistrationResult](Models/FotaV2CallbackRegistrationResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RegisterCallback4Error](Errors/RegisterCallback4Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FotaV2CallbackRegistrationResult&gt; UpdateCallback(string account, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to update the HTTPS callback address.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementCallbacksV2.UpdateCallback(account);
    // TODO: Handle 'response' of type FotaV2CallbackRegistrationResult
}
catch (SdkException<UpdateCallbackError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV2CallbackRegistrationResult](Models/FotaV2CallbackRegistrationResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateCallbackError](Errors/UpdateCallbackError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementCallbacksV3

> Source: [SoftwareManagementCallbacksV3](Api/SoftwareManagementCallbacksV3.cs)

<details>
<summary><code>Task&lt;FotaV3SuccessResult&gt; DeregisterCallback5(string acc, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to delete a previously registered callback URL.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementCallbacksV3.DeregisterCallback5(acc);
    // TODO: Handle 'response' of type FotaV3SuccessResult
}
catch (SdkException<DeregisterCallback5Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>acc</code> | <code>string</code> | Account identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV3SuccessResult](Models/FotaV3SuccessResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeregisterCallback5Error](Errors/DeregisterCallback5Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FotaV3CallbackSummary&gt; ListRegisteredCallbacks5(string acc, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to get the registered callback information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementCallbacksV3.ListRegisteredCallbacks5(acc);
    // TODO: Handle 'response' of type FotaV3CallbackSummary
}
catch (SdkException<ListRegisteredCallbacks5Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>acc</code> | <code>string</code> | Account identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV3CallbackSummary](Models/FotaV3CallbackSummary.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListRegisteredCallbacks5Error](Errors/ListRegisteredCallbacks5Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FotaV3CallbackRegistrationResult&gt; RegisterCallback5(string acc, FotaV3CallbackRegistrationRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows the user to create the HTTPS callback address.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementCallbacksV3.RegisterCallback5(acc, body);
    // TODO: Handle 'response' of type FotaV3CallbackRegistrationResult
}
catch (SdkException<RegisterCallback5Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>acc</code> | <code>string</code> | Account identifier. |
| <code>body</code> | <code>[FotaV3CallbackRegistrationRequest](Models/FotaV3CallbackRegistrationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV3CallbackRegistrationResult](Models/FotaV3CallbackRegistrationResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RegisterCallback5Error](Errors/RegisterCallback5Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FotaV3CallbackRegistrationResult&gt; UpdateCallback2(string acc, FotaV3CallbackRegistrationRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows the user to update the HTTPS callback address.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementCallbacksV3.UpdateCallback2(acc, body);
    // TODO: Handle 'response' of type FotaV3CallbackRegistrationResult
}
catch (SdkException<UpdateCallback2Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>acc</code> | <code>string</code> | Account identifier. |
| <code>body</code> | <code>[FotaV3CallbackRegistrationRequest](Models/FotaV3CallbackRegistrationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV3CallbackRegistrationResult](Models/FotaV3CallbackRegistrationResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateCallback2Error](Errors/UpdateCallback2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementLicensesV1

> Source: [SoftwareManagementLicensesV1](Api/SoftwareManagementLicensesV1.cs)

<details>
<summary><code>Task&lt;V1LicensesAssignedRemovedResult&gt; AssignLicensesToDevices(string account, V1LicensesAssignedRemovedRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Assigns licenses to a specified list of devices so that firmware upgrades can be scheduled for those devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV1.AssignLicensesToDevices(account, body);
    // TODO: Handle 'response' of type V1LicensesAssignedRemovedResult
}
catch (SdkException<AssignLicensesToDevicesError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier in "##########-#####". |
| <code>body</code> | <code>[V1LicensesAssignedRemovedRequest](Models/V1LicensesAssignedRemovedRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1LicensesAssignedRemovedResult](Models/V1LicensesAssignedRemovedResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AssignLicensesToDevicesError](Errors/AssignLicensesToDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1ListOfLicensesToRemoveResult&gt; CreateListOfLicensesToRemove(string account, V1ListOfLicensesToRemoveRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a list of devices from which licenses will be removed if the number of MRC licenses becomes less than the number of assigned licenses.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV1.CreateListOfLicensesToRemove(account, body);
    // TODO: Handle 'response' of type V1ListOfLicensesToRemoveResult
}
catch (SdkException<CreateListOfLicensesToRemoveError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier in "##########-#####". |
| <code>body</code> | <code>[V1ListOfLicensesToRemoveRequest](Models/V1ListOfLicensesToRemoveRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1ListOfLicensesToRemoveResult](Models/V1ListOfLicensesToRemoveResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateListOfLicensesToRemoveError](Errors/CreateListOfLicensesToRemoveError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteListOfLicensesToRemove(string account, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the entire list of cancellation candidate devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.SoftwareManagementLicensesV1.DeleteListOfLicensesToRemove(account);
}
catch (SdkException<DeleteListOfLicensesToRemoveError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier in "##########-#####". |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteListOfLicensesToRemoveError](Errors/DeleteListOfLicensesToRemoveError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1ListOfLicensesToRemove&gt; ListLicensesToRemove(string account, string startIndex, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of devices from which licenses will be removed if the number of MRC licenses becomes less than the number of assigned licenses.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV1.ListLicensesToRemove(account, startIndex);
    // TODO: Handle 'response' of type V1ListOfLicensesToRemove
}
catch (SdkException<ListLicensesToRemoveError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier in "##########-#####". |
| <code>startIndex</code> | <code>string</code> | The zero-based number of the first record to return. Set startIndex=0 for the first request. If there are more than 1,000 devices in the response, set startIndex=1000 for the second request, 2000 for the third request, etc. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1ListOfLicensesToRemove](Models/V1ListOfLicensesToRemove.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListLicensesToRemoveError](Errors/ListLicensesToRemoveError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1LicensesAssignedRemovedResult&gt; RemoveLicensesFromDevices(string account, V1LicensesAssignedRemovedRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove unused licenses from device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV1.RemoveLicensesFromDevices(account, body);
    // TODO: Handle 'response' of type V1LicensesAssignedRemovedResult
}
catch (SdkException<RemoveLicensesFromDevicesError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier in "##########-#####". |
| <code>body</code> | <code>[V1LicensesAssignedRemovedRequest](Models/V1LicensesAssignedRemovedRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1LicensesAssignedRemovedResult](Models/V1LicensesAssignedRemovedResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RemoveLicensesFromDevicesError](Errors/RemoveLicensesFromDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementLicensesV2

> Source: [SoftwareManagementLicensesV2](Api/SoftwareManagementLicensesV2.cs)

<details>
<summary><code>Task&lt;V2LicensesAssignedRemovedResult&gt; AssignLicensesToDevices2(string account, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to assign licenses to a list of devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV2.AssignLicensesToDevices2(account);
    // TODO: Handle 'response' of type V2LicensesAssignedRemovedResult
}
catch (SdkException<AssignLicensesToDevices2Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V2LicensesAssignedRemovedResult](Models/V2LicensesAssignedRemovedResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AssignLicensesToDevices2Error](Errors/AssignLicensesToDevices2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V2ListOfLicensesToRemoveResult&gt; CreateListOfLicensesToRemove2(string account, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The license cancel endpoint allows user to create a list of license cancellation candidate devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV2.CreateListOfLicensesToRemove2(account);
    // TODO: Handle 'response' of type V2ListOfLicensesToRemoveResult
}
catch (SdkException<CreateListOfLicensesToRemove2Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V2ListOfLicensesToRemoveResult](Models/V2ListOfLicensesToRemoveResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateListOfLicensesToRemove2Error](Errors/CreateListOfLicensesToRemove2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FotaV2SuccessResult&gt; DeleteListOfLicensesToRemove2(string account, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to delete a created cancel candidate device list.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV2.DeleteListOfLicensesToRemove2(account);
    // TODO: Handle 'response' of type FotaV2SuccessResult
}
catch (SdkException<DeleteListOfLicensesToRemove2Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV2SuccessResult](Models/FotaV2SuccessResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteListOfLicensesToRemove2Error](Errors/DeleteListOfLicensesToRemove2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V2LicenseSummary&gt; GetAccountLicenseStatus2(string account, string? lastSeenDeviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The endpoint allows user to list license usage.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV2.GetAccountLicenseStatus2(account, lastSeenDeviceId);
    // TODO: Handle 'response' of type V2LicenseSummary
}
catch (SdkException<GetAccountLicenseStatus2Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |
| <code>lastSeenDeviceId</code> | <code>string?</code> | Last seen device identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V2LicenseSummary](Models/V2LicenseSummary.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAccountLicenseStatus2Error](Errors/GetAccountLicenseStatus2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V2ListOfLicensesToRemove&gt; ListLicensesToRemove2(string account, string? startIndex, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The license cancel endpoint allows user to list registered license cancellation candidate devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV2.ListLicensesToRemove2(account, startIndex);
    // TODO: Handle 'response' of type V2ListOfLicensesToRemove
}
catch (SdkException<ListLicensesToRemove2Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |
| <code>startIndex</code> | <code>string?</code> | Start index to retrieve. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V2ListOfLicensesToRemove](Models/V2ListOfLicensesToRemove.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListLicensesToRemove2Error](Errors/ListLicensesToRemove2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V2LicensesAssignedRemovedResult&gt; RemoveLicensesFromDevices2(string account, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to remove licenses from a list of devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV2.RemoveLicensesFromDevices2(account);
    // TODO: Handle 'response' of type V2LicensesAssignedRemovedResult
}
catch (SdkException<RemoveLicensesFromDevices2Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V2LicensesAssignedRemovedResult](Models/V2LicensesAssignedRemovedResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RemoveLicensesFromDevices2Error](Errors/RemoveLicensesFromDevices2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementLicensesV3

> Source: [SoftwareManagementLicensesV3](Api/SoftwareManagementLicensesV3.cs)

<details>
<summary><code>Task&lt;V3LicenseAssignedRemovedResult&gt; AssignLicensesToDevices3(string acc, V3LicenseImei body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to assign licenses to a list of devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV3.AssignLicensesToDevices3(acc, body);
    // TODO: Handle 'response' of type V3LicenseAssignedRemovedResult
}
catch (SdkException<AssignLicensesToDevices3Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>acc</code> | <code>string</code> | Account identifier. |
| <code>body</code> | <code>[V3LicenseImei](Models/V3LicenseImei.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V3LicenseAssignedRemovedResult](Models/V3LicenseAssignedRemovedResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AssignLicensesToDevices3Error](Errors/AssignLicensesToDevices3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V3LicenseSummary&gt; GetAccountLicensesStatus(string acc, string? lastSeenDeviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The endpoint allows user to list license usage.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV3.GetAccountLicensesStatus(acc, lastSeenDeviceId);
    // TODO: Handle 'response' of type V3LicenseSummary
}
catch (SdkException<GetAccountLicensesStatusError> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>acc</code> | <code>string</code> | Account identifier. |
| <code>lastSeenDeviceId</code> | <code>string?</code> | Last seen device identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V3LicenseSummary](Models/V3LicenseSummary.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAccountLicensesStatusError](Errors/GetAccountLicensesStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V3LicenseAssignedRemovedResult&gt; RemoveLicensesFromDevices3(string acc, V3LicenseImei body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to remove licenses from a list of devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementLicensesV3.RemoveLicensesFromDevices3(acc, body);
    // TODO: Handle 'response' of type V3LicenseAssignedRemovedResult
}
catch (SdkException<RemoveLicensesFromDevices3Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>acc</code> | <code>string</code> | Account identifier. |
| <code>body</code> | <code>[V3LicenseImei](Models/V3LicenseImei.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V3LicenseAssignedRemovedResult](Models/V3LicenseAssignedRemovedResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RemoveLicensesFromDevices3Error](Errors/RemoveLicensesFromDevices3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementReportsV1

> Source: [SoftwareManagementReportsV1](Api/SoftwareManagementReportsV1.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeviceUpgradeHistory&gt;&gt; GetDeviceFirmwareUpgradeHistory(string account, string deviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the upgrade history of the specified device from the previous six months.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementReportsV1.GetDeviceFirmwareUpgradeHistory(account, deviceId);
    // TODO: Handle 'response' of type IReadOnlyList<DeviceUpgradeHistory>
}
catch (SdkException<GetDeviceFirmwareUpgradeHistoryError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier in "##########-#####". |
| <code>deviceId</code> | <code>string</code> | The IMEI of the device. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeviceUpgradeHistory](Models/DeviceUpgradeHistory.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetDeviceFirmwareUpgradeHistoryError](Errors/GetDeviceFirmwareUpgradeHistoryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceListQueryResult&gt; ListAccountDevices(string account, string startIndex, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an array of all devices in the specified account. Each device object includes information needed for managing firmware, including the device make and model, MDN and IMEI, and current firmware version.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementReportsV1.ListAccountDevices(account, startIndex);
    // TODO: Handle 'response' of type DeviceListQueryResult
}
catch (SdkException<ListAccountDevicesError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier in "##########-#####". |
| <code>startIndex</code> | <code>string</code> | Only return devices with IMEIs larger than this value. Use 0 for the first request. If `hasMoreData`=true in the response, use the `lastSeenDeviceId` value from the response as the startIndex in the next request. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceListQueryResult](Models/DeviceListQueryResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListAccountDevicesError](Errors/ListAccountDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpgradeListQueryResult&gt; ListUpgradesForSpecifiedStatus(string account, UpgradeStatus upgradeStatus, string startIndex, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all upgrades with a specified status.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementReportsV1.ListUpgradesForSpecifiedStatus(account,
        upgradeStatus,
        startIndex);
    // TODO: Handle 'response' of type UpgradeListQueryResult
}
catch (SdkException<ListUpgradesForSpecifiedStatusError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier in "##########-#####". |
| <code>upgradeStatus</code> | <code>[UpgradeStatus](Models/Enums/UpgradeStatus.cs)</code> | The status of the upgrades that you want to retrieve. |
| <code>startIndex</code> | <code>string</code> | The zero-based number of the first record to return. Set startIndex=0 for the first request. If `hasMoreFlag`=true in the response, use the `lastSeenUpgradeId` value from the response as the startIndex in the next request. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpgradeListQueryResult](Models/UpgradeListQueryResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListUpgradesForSpecifiedStatusError](Errors/ListUpgradesForSpecifiedStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementReportsV2

> Source: [SoftwareManagementReportsV2](Api/SoftwareManagementReportsV2.cs)

<details>
<summary><code>Task&lt;V2CampaignDevice&gt; GetCampaignDeviceStatus(string account, string campaignId, string? lastSeenDeviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The report endpoint allows user to get the full list of device of a campaign.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementReportsV2.GetCampaignDeviceStatus(account,
        campaignId,
        lastSeenDeviceId);
    // TODO: Handle 'response' of type V2CampaignDevice
}
catch (SdkException<GetCampaignDeviceStatusError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |
| <code>campaignId</code> | <code>string</code> | Campaign identifier. |
| <code>lastSeenDeviceId</code> | <code>string?</code> | Last seen device identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V2CampaignDevice](Models/V2CampaignDevice.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCampaignDeviceStatusError](Errors/GetCampaignDeviceStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V2CampaignHistory&gt; GetCampaignHistoryByStatus(string account, string campaignStatus, string? lastSeenCampaignId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The report endpoint allows user to get campaign history of an account for specified status.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementReportsV2.GetCampaignHistoryByStatus(account,
        campaignStatus,
        lastSeenCampaignId);
    // TODO: Handle 'response' of type V2CampaignHistory
}
catch (SdkException<GetCampaignHistoryByStatusError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |
| <code>campaignStatus</code> | <code>string</code> | Status of the campaign. |
| <code>lastSeenCampaignId</code> | <code>string?</code> | Last seen campaign Id. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V2CampaignHistory](Models/V2CampaignHistory.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCampaignHistoryByStatusError](Errors/GetCampaignHistoryByStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeviceSoftwareUpgrade&gt;&gt; GetDeviceFirmwareUpgradeHistory2(string account, string deviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The endpoint allows user to get software upgrade history of a device based on device IMEI.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementReportsV2.GetDeviceFirmwareUpgradeHistory2(account, deviceId);
    // TODO: Handle 'response' of type IReadOnlyList<DeviceSoftwareUpgrade>
}
catch (SdkException<GetDeviceFirmwareUpgradeHistory2Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |
| <code>deviceId</code> | <code>string</code> | Device IMEI identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeviceSoftwareUpgrade](Models/DeviceSoftwareUpgrade.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetDeviceFirmwareUpgradeHistory2Error](Errors/GetDeviceFirmwareUpgradeHistory2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V2AccountDeviceList&gt; ListAccountDevices2(string account, string? lastSeenDeviceId, string? distributionType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The device endpoint gets devices information of an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementReportsV2.ListAccountDevices2(account,
        lastSeenDeviceId,
        distributionType);
    // TODO: Handle 'response' of type V2AccountDeviceList
}
catch (SdkException<ListAccountDevices2Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |
| <code>lastSeenDeviceId</code> | <code>string?</code> | Last seen device identifier. |
| <code>distributionType</code> | <code>string?</code> | Filter distributionType to get specific type of devices. Values is LWM2M, OMD-DM or HTTP. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V2AccountDeviceList](Models/V2AccountDeviceList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListAccountDevices2Error](Errors/ListAccountDevices2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;SoftwarePackage&gt;&gt; ListAvailableSoftware(string account, string? distributionType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows user to list a certain type of software of an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementReportsV2.ListAvailableSoftware(account, distributionType);
    // TODO: Handle 'response' of type IReadOnlyList<SoftwarePackage>
}
catch (SdkException<ListAvailableSoftwareError> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |
| <code>distributionType</code> | <code>string?</code> | Filter distributionType to get specific type of software. Value is LWM2M, OMD-DM or HTTP. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[SoftwarePackage](Models/SoftwarePackage.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListAvailableSoftwareError](Errors/ListAvailableSoftwareError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementReportsV3

> Source: [SoftwareManagementReportsV3](Api/SoftwareManagementReportsV3.cs)

<details>
<summary><code>Task&lt;V3CampaignDevice&gt; GetCampaignDeviceStatus2(string acc, string campaignId, string? lastSeenDeviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a list of all devices in a campaign and the status of each device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementReportsV3.GetCampaignDeviceStatus2(acc, campaignId, lastSeenDeviceId);
    // TODO: Handle 'response' of type V3CampaignDevice
}
catch (SdkException<GetCampaignDeviceStatus2Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>acc</code> | <code>string</code> | Account identifier. |
| <code>campaignId</code> | <code>string</code> | Campaign identifier. |
| <code>lastSeenDeviceId</code> | <code>string?</code> | Last seen device identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V3CampaignDevice](Models/V3CampaignDevice.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCampaignDeviceStatus2Error](Errors/GetCampaignDeviceStatus2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V3CampaignHistory&gt; GetCampaignHistoryByStatus2(string acc, CampaignStatus campaignStatus, string? lastSeenCampaignId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a list of campaigns for an account that have a specified campaign status.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementReportsV3.GetCampaignHistoryByStatus2(acc,
        campaignStatus,
        lastSeenCampaignId);
    // TODO: Handle 'response' of type V3CampaignHistory
}
catch (SdkException<GetCampaignHistoryByStatus2Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>acc</code> | <code>string</code> | Account identifier. |
| <code>campaignStatus</code> | <code>[CampaignStatus](Models/Enums/CampaignStatus.cs)</code> | Campaign status. |
| <code>lastSeenCampaignId</code> | <code>string?</code> | Last seen campaign Id. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V3CampaignHistory](Models/V3CampaignHistory.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCampaignHistoryByStatus2Error](Errors/GetCampaignHistoryByStatus2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeviceFirmwareUpgrade&gt;&gt; GetDeviceFirmwareUpgradeHistory3(string acc, string deviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve campaign history for a specific device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementReportsV3.GetDeviceFirmwareUpgradeHistory3(acc, deviceId);
    // TODO: Handle 'response' of type IReadOnlyList<DeviceFirmwareUpgrade>
}
catch (SdkException<GetDeviceFirmwareUpgradeHistory3Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>acc</code> | <code>string</code> | Account identifier. |
| <code>deviceId</code> | <code>string</code> | Device IMEI identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeviceFirmwareUpgrade](Models/DeviceFirmwareUpgrade.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetDeviceFirmwareUpgradeHistory3Error](Errors/GetDeviceFirmwareUpgradeHistory3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementSubscriptionsV1

> Source: [SoftwareManagementSubscriptionsV1](Api/SoftwareManagementSubscriptionsV1.cs)

<details>
<summary><code>Task&lt;AccountLicenseInfo&gt; GetAccountLicenseStatus(string account, string startIndex, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns information about an account's Software Management Services licenses and a list of licensed devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementSubscriptionsV1.GetAccountLicenseStatus(account, startIndex);
    // TODO: Handle 'response' of type AccountLicenseInfo
}
catch (SdkException<GetAccountLicenseStatusError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier in "##########-#####". |
| <code>startIndex</code> | <code>string</code> | The zero-based number of the first record to return. Set startIndex=0 for the first request. If there are more than 1,000 devices in the response, set startIndex=1000 for the second request, 2000 for the third request, etc. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountLicenseInfo](Models/AccountLicenseInfo.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAccountLicenseStatusError](Errors/GetAccountLicenseStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1AccountSubscription&gt; GetAccountSubscriptionStatus(string account, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This subscriptions endpoint retrieves an account's current Software Management Service subscription status.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementSubscriptionsV1.GetAccountSubscriptionStatus(account);
    // TODO: Handle 'response' of type V1AccountSubscription
}
catch (SdkException<GetAccountSubscriptionStatusError> ex)
{
    if (ex.Error.TryGetFotaV1Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV1Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier in "##########-#####". |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1AccountSubscription](Models/V1AccountSubscription.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAccountSubscriptionStatusError](Errors/GetAccountSubscriptionStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementSubscriptionsV2

> Source: [SoftwareManagementSubscriptionsV2](Api/SoftwareManagementSubscriptionsV2.cs)

<details>
<summary><code>Task&lt;FotaV2Subscription&gt; GetAccountSubscriptionStatus2(string account, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint retrieves a FOTA subscription by account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementSubscriptionsV2.GetAccountSubscriptionStatus2(account);
    // TODO: Handle 'response' of type FotaV2Subscription
}
catch (SdkException<GetAccountSubscriptionStatus2Error> ex)
{
    if (ex.Error.TryGetFotaV2Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV2Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>account</code> | <code>string</code> | Account identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV2Subscription](Models/FotaV2Subscription.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAccountSubscriptionStatus2Error](Errors/GetAccountSubscriptionStatus2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SoftwareManagementSubscriptionsV3

> Source: [SoftwareManagementSubscriptionsV3](Api/SoftwareManagementSubscriptionsV3.cs)

<details>
<summary><code>Task&lt;FotaV3Subscription&gt; GetAccountSubscriptionStatus3(string acc, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint retrieves a FOTA subscription by account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SoftwareManagementSubscriptionsV3.GetAccountSubscriptionStatus3(acc);
    // TODO: Handle 'response' of type FotaV3Subscription
}
catch (SdkException<GetAccountSubscriptionStatus3Error> ex)
{
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // TODO: Handle 'error' of type FotaV3Result
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>acc</code> | <code>string</code> | Account identifier. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FotaV3Subscription](Models/FotaV3Subscription.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAccountSubscriptionStatus3Error](Errors/GetAccountSubscriptionStatus3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Targets

> Source: [Targets](Api/Targets.cs)

<details>
<summary><code>Task&lt;CreateIoTApplicationResponse&gt; CreateAzureCentralIoTApplication(string billingaccountId, CreateIoTApplicationRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deploy a new Azure IoT Central application based on the Verizon ARM template within the specified Azure Active Directory account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Targets.CreateAzureCentralIoTApplication(billingaccountId, body);
    // TODO: Handle 'response' of type CreateIoTApplicationResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>billingaccountId</code> | <code>string</code> | TThe ThingSpace ID of the authenticating billing account. |
| <code>body</code> | <code>[CreateIoTApplicationRequest](Models/CreateIoTApplicationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateIoTApplicationResponse](Models/CreateIoTApplicationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Target&gt; CreateTarget(CreateTargetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Define a target to receive data streams, alerts, or callbacks. After creating the target resource, use its ID in a subscription to set up a data stream.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Targets.CreateTarget(body);
    // TODO: Handle 'response' of type Target
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[CreateTargetRequest](Models/CreateTargetRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Target](Models/Target.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteTarget(DeleteTargetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove a target from a ThingSpace account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Targets.DeleteTarget(body);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[DeleteTargetRequest](Models/DeleteTargetRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenerateExternalIdResult&gt; GenerateTargetExternalId(GenerateExternalIdRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a unique string that ThingSpace will pass to AWS for increased security.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Targets.GenerateTargetExternalId(body);
    // TODO: Handle 'response' of type GenerateExternalIdResult
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GenerateExternalIdRequest](Models/GenerateExternalIdRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateExternalIdResult](Models/GenerateExternalIdResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Target&gt;&gt; QueryTarget(QueryTargetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Search for targets by property values. Returns an array of all matching target resources.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Targets.QueryTarget(body);
    // TODO: Handle 'response' of type IReadOnlyList<Target>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[QueryTargetRequest](Models/QueryTargetRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Target](Models/Target.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ThingSpaceQualityOfServiceApiActions

> Source: [ThingSpaceQualityOfServiceApiActions](Api/ThingSpaceQualityOfServiceApiActions.cs)

<details>
<summary><code>Task&lt;Success201&gt; CreateAThingSpaceQualityOfServiceApiSubscription(SubscribeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a QoS elevation subscription ID and activates the subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ThingSpaceQualityOfServiceApiActions.CreateAThingSpaceQualityOfServiceApiSubscription(body);
    // TODO: Handle 'response' of type Success201
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[SubscribeRequest](Models/SubscribeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Success201](Models/Success201.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Success201&gt; StopAThingSpaceQualityOfServiceApiSubscription(string accountName, string qosSubscriptionId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Stops an active ThingSpace Quality of Service API subscription using the account name and the subscription ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ThingSpaceQualityOfServiceApiActions.StopAThingSpaceQualityOfServiceApiSubscription(accountName,
        qosSubscriptionId);
    // TODO: Handle 'response' of type Success201
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | - |
| <code>qosSubscriptionId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Success201](Models/Success201.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UpdatePricePlanTriggers

> Source: [UpdatePricePlanTriggers](Api/UpdatePricePlanTriggers.cs)

<details>
<summary><code>Task&lt;TriggerResponse&gt; UpdateTriggerRules(V2TriggersRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a usage trigger at the account level, device level or a price plan trigger for all devices on the account

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UpdatePricePlanTriggers.UpdateTriggerRules(body);
    // TODO: Handle 'response' of type TriggerResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[V2TriggersRequest1](Models/AnyOf/V2TriggersRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TriggerResponse](Models/TriggerResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UpdateTriggers

> Source: [UpdateTriggers](Api/UpdateTriggers.cs)

<details>
<summary><code>Task&lt;Success&gt; UpdateAllAvailableTriggers(RequestTrigger? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the promotional triggers for pseudo-MDN.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UpdateTriggers.UpdateAllAvailableTriggers(body);
    // TODO: Handle 'response' of type Success
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[RequestTrigger?](Models/RequestTrigger.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Success](Models/Success.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UsageTriggerManagement

> Source: [UsageTriggerManagement](Api/UsageTriggerManagement.cs)

<details>
<summary><code>Task&lt;UsageTriggerResponse&gt; CreateNewTrigger(UsageTriggerAddRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a new usage trigger, which will send an alert when the number of device location service transactions reaches a specified percentage of the monthly subscription amount.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsageTriggerManagement.CreateNewTrigger(body);
    // TODO: Handle 'response' of type UsageTriggerResponse
}
catch (SdkException<CreateNewTriggerError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[UsageTriggerAddRequest?](Models/UsageTriggerAddRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsageTriggerResponse](Models/UsageTriggerResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateNewTriggerError](Errors/CreateNewTriggerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceLocationSuccessResult&gt; DeleteTrigger(string accountName, string triggerId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

eletes the specified usage trigger from the given account

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsageTriggerManagement.DeleteTrigger(accountName, triggerId);
    // TODO: Handle 'response' of type DeviceLocationSuccessResult
}
catch (SdkException<DeleteTriggerError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>accountName</code> | <code>string</code> | Account name |
| <code>triggerId</code> | <code>string</code> | Usage trigger ID |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceLocationSuccessResult](Models/DeviceLocationSuccessResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteTriggerError](Errors/DeleteTriggerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UsageTriggerResponse&gt; UpdateTrigger(string triggerId, UsageTriggerUpdateRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an existing usage trigger


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsageTriggerManagement.UpdateTrigger(triggerId, body);
    // TODO: Handle 'response' of type UsageTriggerResponse
}
catch (SdkException<UpdateTriggerError> ex)
{
    if (ex.Error.TryGetDeviceLocationResult(out var error))
    {
        // TODO: Handle 'error' of type DeviceLocationResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>triggerId</code> | <code>string</code> | Usage trigger ID |
| <code>body</code> | <code>[UsageTriggerUpdateRequest?](Models/UsageTriggerUpdateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsageTriggerResponse](Models/UsageTriggerResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateTriggerError](Errors/UpdateTriggerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## WirelessNetworkPerformance

> Source: [WirelessNetworkPerformance](Api/WirelessNetworkPerformance.cs)

<details>
<summary><code>Task&lt;WnpRequestResponse&gt; DeviceExperience30DaysHistory(GetDeviceExperienceScoreHistoryRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

A report of a specific device's service scores over a 30 day period.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WirelessNetworkPerformance.DeviceExperience30DaysHistory(body);
    // TODO: Handle 'response' of type WnpRequestResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GetDeviceExperienceScoreHistoryRequest](Models/GetDeviceExperienceScoreHistoryRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WnpRequestResponse](Models/WnpRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WnpRequestResponse&gt; DeviceExperienceBulkLatest(GetDeviceExperienceScoreBulkRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Run a report to view the latest device experience score for specific devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WirelessNetworkPerformance.DeviceExperienceBulkLatest(body);
    // TODO: Handle 'response' of type WnpRequestResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GetDeviceExperienceScoreBulkRequest](Models/GetDeviceExperienceScoreBulkRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WnpRequestResponse](Models/WnpRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WnpRequestResponse&gt; Domestic4GAnd5GNationwideNetworkCoverage(M2MV1IntelligenceWirelessCoverageRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Run a report for FWA Address qualification or to determine network types available and available coverage. Network types covered include: CAT-M, NB-IOT, LTE, LTE-AWS, 5GNW, MMWAVE and C-BAND.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WirelessNetworkPerformance.Domestic4GAnd5GNationwideNetworkCoverage(body);
    // TODO: Handle 'response' of type WnpRequestResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[M2MV1IntelligenceWirelessCoverageRequest](Models/AnyOf/M2MV1IntelligenceWirelessCoverageRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WnpRequestResponse](Models/WnpRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WnpRequestResponse&gt; NearRealTimeNetworkConditions(GetNetworkConditionsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

WNP Query for current network condition.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WirelessNetworkPerformance.NearRealTimeNetworkConditions(body);
    // TODO: Handle 'response' of type WnpRequestResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GetNetworkConditionsRequest](Models/GetNetworkConditionsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WnpRequestResponse](Models/WnpRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WnpRequestResponse&gt; SiteProximity(GetNetworkConditionsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Identify the direction and general distance of nearby cell sites and the technology supported by the equipment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WirelessNetworkPerformance.SiteProximity(body);
    // TODO: Handle 'response' of type WnpRequestResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GetNetworkConditionsRequest](Models/GetNetworkConditionsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WnpRequestResponse](Models/WnpRequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeviceRoleController

> Source: [DeviceRoleController](Api/DeviceRoleController.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DeviceRole&gt;&gt; GetAclRulesByVendorId(string vendorId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This API allows the user to get the access control rules defined for them.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeviceRoleController.GetAclRulesByVendorId(vendorId);
    // TODO: Handle 'response' of type IReadOnlyList<DeviceRole>
}
catch (SdkException<GetAclRulesByVendorIdError> ex)
{
    if (ex.Error.TryGetString(out var error))
    {
        // TODO: Handle 'error' of type string
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vendorId</code> | <code>string</code> | The user's Vendor ID |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DeviceRole](Models/DeviceRole.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAclRulesByVendorIdError](Errors/GetAclRulesByVendorIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## EUiccDeviceProfileManagement

> Source: [EUiccDeviceProfileManagement](Api/EUiccDeviceProfileManagement.cs)

<details>
<summary><code>Task&lt;RequestResponse&gt; DeleteLocalProfile(ProfileChangeStateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a local profile from eUICC devices. If the local profile is enabled, it will first be disabled and the boot or default profile will be enabled.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EUiccDeviceProfileManagement.DeleteLocalProfile(body);
    // TODO: Handle 'response' of type RequestResponse
}
catch (SdkException<DeleteLocalProfileError> ex)
{
    if (ex.Error.TryGetRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponse
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ProfileChangeStateRequest](Models/ProfileChangeStateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestResponse](Models/RequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteLocalProfileError](Errors/DeleteLocalProfileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RequestResponse&gt; DisableLocalProfile(ProfileChangeStateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Disable a local profile on eUICC devices. The default or boot profile will become the enabled profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EUiccDeviceProfileManagement.DisableLocalProfile(body);
    // TODO: Handle 'response' of type RequestResponse
}
catch (SdkException<DisableLocalProfileError> ex)
{
    if (ex.Error.TryGetRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponse
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ProfileChangeStateRequest](Models/ProfileChangeStateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestResponse](Models/RequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DisableLocalProfileError](Errors/DisableLocalProfileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; DownloadLocalProfileToDisable(ProfileChangeStateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Downloads an eUICC local profile to devices and leaves the profile disabled.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EUiccDeviceProfileManagement.DownloadLocalProfileToDisable(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<DownloadLocalProfileToDisableError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ProfileChangeStateRequest](Models/ProfileChangeStateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DownloadLocalProfileToDisableError](Errors/DownloadLocalProfileToDisableError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeviceManagementResult&gt; DownloadLocalProfileToEnable(ProfileChangeStateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Downloads an eUICC local profile to devices and enables the profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EUiccDeviceProfileManagement.DownloadLocalProfileToEnable(body);
    // TODO: Handle 'response' of type DeviceManagementResult
}
catch (SdkException<DownloadLocalProfileToEnableError> ex)
{
    if (ex.Error.TryGetConnectivityManagementResult(out var error))
    {
        // TODO: Handle 'error' of type ConnectivityManagementResult
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ProfileChangeStateRequest](Models/ProfileChangeStateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeviceManagementResult](Models/DeviceManagementResult.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DownloadLocalProfileToEnableError](Errors/DownloadLocalProfileToEnableError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RequestResponse&gt; EnableLocalProfile(ProfileChangeStateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enable a local profile that has been downloaded to eUICC devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EUiccDeviceProfileManagement.EnableLocalProfile(body);
    // TODO: Handle 'response' of type RequestResponse
}
catch (SdkException<EnableLocalProfileError> ex)
{
    if (ex.Error.TryGetRestErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type RestErrorResponse
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ProfileChangeStateRequest](Models/ProfileChangeStateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestResponse](Models/RequestResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EnableLocalProfileError](Errors/EnableLocalProfileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## MapMessageController

> Source: [MapMessageController](Api/MapMessageController.cs)

<details>
<summary><code>Task DeleteMapMessage(string regionId, string i10Nid, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes a map message for the specified region and intersection ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.MapMessageController.DeleteMapMessage(regionId, i10Nid);
}
catch (SdkException<DeleteMapMessageError> ex)
{
    if (ex.Error.TryGetMdmErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type MdmErrorResponse
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>regionId</code> | <code>string</code> | Region ID to filter the map messages. |
| <code>i10Nid</code> | <code>string</code> | Intersection ID to filter the map messages. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteMapMessageError](Errors/DeleteMapMessageError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;string&gt; DownloadMapMessages(GeofencePolygon geofence, string vendorId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint is deprecated. (Use /api/v2/mapdata/query for new integrations).

This endpoint allows user to download SAE J2735 or ETSI MAP messages in ASN.1 UPER base64 encoded format. The area for the MAP messages is needed to be defined in the query.


**Required request header:** `Accept` — specifies the response format. Omitting this header will result in a `400 Bad Request`. Supported values:
- `text/plain` — ASN.1 UPER base64-encoded MAP messages (one per line)
- `application/json` — JSON-encoded MAP messages

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MapMessageController.DownloadMapMessages(geofence, vendorId);
    // TODO: Handle 'response' of type string
}
catch (SdkException<DownloadMapMessagesError> ex)
{
    if (ex.Error.TryGetMdmErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type MdmErrorResponse
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>geofence</code> | <code>[GeofencePolygon](Models/GeofencePolygon.cs)</code> | GeoJSON Polygon defining the area to retrieve MAP messages for. |
| <code>vendorId</code> | <code>string</code> | The VendorID set during the Vendor registration call. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>string</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DownloadMapMessagesError](Errors/DownloadMapMessagesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;string&gt; IngestMapMessages(string vendorId, EtxMessageStandardEnum mapDataMessageStandard, EtxMapDataIngestRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows the user to upload map messages in ASN.1 UPER base64 encoded format or JER (JSON) formats. The MAP data message can have more than one intersections in it.
Both SAE and ETSI defined MAP messages are supported. The SAE type MAP messages have to be wrapped in a MessageFrame, as defined in the SAE J2735 standard.
The ETSI type MAP messages are expected as MAPEM structures that include the ETSI header, as defined in the ETSI TS 103 301 standard.
Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.


**Required request header:** `Content-Type` — specifies the format of the request body. Omitting or sending an unsupported value will result in a `415 Unsupported Media Type`. Supported values:
- `text/plain` — ASN.1 UPER base64-encoded MAP message
- `application/json` — JSON representation of the MAP message

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MapMessageController.IngestMapMessages(vendorId, mapDataMessageStandard, body);
    // TODO: Handle 'response' of type string
}
catch (SdkException<IngestMapMessagesError> ex)
{
    if (ex.Error.TryGetMdmErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type MdmErrorResponse
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vendorId</code> | <code>string</code> | The VendorID set during the Vendor registration call. |
| <code>mapDataMessageStandard</code> | <code>[EtxMessageStandardEnum](Models/Enums/EtxMessageStandardEnum.cs)</code> | Select which V2X messaging standard will be used for the message generation. The following options are supported:<br>- "etsi": The message will be generated using the ETSI (European) standard (e.g. MAPEM).<br>- "sae": The message will be generated using the SAE J2735 (North American) standard (e.g. MAP).<br>- if not sent while POST, defaults to "sae" |
| <code>body</code> | <code>[EtxMapDataIngestRequest](Models/EtxMapDataIngestRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>string</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[IngestMapMessagesError](Errors/IngestMapMessagesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;object&gt;&gt; QueryMapMessages(string vendorId, MapDataQueryRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows users to download SAE J2735 or ETSI MAP messages as a JSON list. 
Depending on the expectedType parameter, the response contains either ASN.1 UPER base64-encoded messages with their respective region and intersection IDs, or fully decoded JSON messages. 
The area for MAP message retrieval must be defined in the request body using one of two methods: 
An array of region and intersection ID pairs, or a GeoJSON geofence specification.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MapMessageController.QueryMapMessages(vendorId, body);
    // TODO: Handle 'response' of type IReadOnlyList<object>
}
catch (SdkException<QueryMapMessagesError> ex)
{
    if (ex.Error.TryGetMdmErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type MdmErrorResponse
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>vendorId</code> | <code>string</code> | The VendorID set during the Vendor registration call. |
| <code>body</code> | <code>[MapDataQueryRequest](Models/AnyOf/MapDataQueryRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;object&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryMapMessagesError](Errors/QueryMapMessagesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

