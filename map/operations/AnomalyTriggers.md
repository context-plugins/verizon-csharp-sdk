<!-- Generated file — do not edit; regenerated with the SDK. -->

# AnomalyTriggers — operations

Accessor: `client.AnomalyTriggers` · Source: `Api/AnomalyTriggers.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateAnomalyDetectionTrigger

- **Signature**: `CreateAnomalyDetectionTrigger(CreateTriggerRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AnomalyDetectionTrigger`
- **Error**: `SdkException<CreateAnomalyDetectionTriggerError>` — **Case A (typed)**
- **Error accessors**: `TryGetIntelligenceResult(out IntelligenceResult)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateTriggerRequest` | `Models/CreateTriggerRequest.cs` |
| `AnomalyDetectionTrigger` | `Models/AnomalyDetectionTrigger.cs` |
| `CreateAnomalyDetectionTriggerError` | `Errors/CreateAnomalyDetectionTriggerError.cs` |
| `IntelligenceResult` | `Models/IntelligenceResult.cs` |

### DeleteAnomalyDetectionTrigger

- **Signature**: `DeleteAnomalyDetectionTrigger(string triggerId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AnomalyDetectionTrigger`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AnomalyDetectionTrigger` | `Models/AnomalyDetectionTrigger.cs` |

### ListAnomalyDetectionTriggerSettings

- **Signature**: `ListAnomalyDetectionTriggerSettings(string triggerId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<GetTriggerResponseList>`
- **Error**: `SdkException<ListAnomalyDetectionTriggerSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetIntelligenceResult(out IntelligenceResult)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTriggerResponseList` | `Models/GetTriggerResponseList.cs` |
| `ListAnomalyDetectionTriggerSettingsError` | `Errors/ListAnomalyDetectionTriggerSettingsError.cs` |
| `IntelligenceResult` | `Models/IntelligenceResult.cs` |

### ListAnomalyDetectionTriggers

- **Signature**: `ListAnomalyDetectionTriggers(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<GetTriggerResponseList>`
- **Error**: `SdkException<ListAnomalyDetectionTriggersError>` — **Case A (typed)**
- **Error accessors**: `TryGetIntelligenceResult(out IntelligenceResult)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTriggerResponseList` | `Models/GetTriggerResponseList.cs` |
| `ListAnomalyDetectionTriggersError` | `Errors/ListAnomalyDetectionTriggersError.cs` |
| `IntelligenceResult` | `Models/IntelligenceResult.cs` |

### UpdateAnomalyDetectionTrigger

- **Signature**: `UpdateAnomalyDetectionTrigger(UpdateTriggerRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AnomalyDetectionTrigger`
- **Error**: `SdkException<UpdateAnomalyDetectionTriggerError>` — **Case A (typed)**
- **Error accessors**: `TryGetIntelligenceResult(out IntelligenceResult)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateTriggerRequest` | `Models/UpdateTriggerRequest.cs` |
| `AnomalyDetectionTrigger` | `Models/AnomalyDetectionTrigger.cs` |
| `UpdateAnomalyDetectionTriggerError` | `Errors/UpdateAnomalyDetectionTriggerError.cs` |
| `IntelligenceResult` | `Models/IntelligenceResult.cs` |

